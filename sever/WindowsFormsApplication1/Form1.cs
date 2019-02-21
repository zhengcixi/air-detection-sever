using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        /*
         delegate string ProcessDelegate(int i);   //定义一个委托
         返回类型为string
         只有一个参数，为int型
         */
        
        private delegate void SetTextValueCallBack(string strValue);  //定义回调，用于跨线程访问
        private SetTextValueCallBack setCallBack;   //声明回调

        private delegate void ReceiveMsgCallBack(string strReceive);
        private ReceiveMsgCallBack receiveCallBack;

        private delegate void SetCmbCallBack(string strItem);
        private SetCmbCallBack setCmbCallBack;


        Socket socketSend;  //通信的socket
        Socket socketWatch; //监听的socket


        //存放远程连接的客户端的IP地址和Socket的集合
        //dicSocket是一个字典，键为string，值为Socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        Thread AcceptSocketThread;  //创建监听连接的线程
        Thread threadReceive;       //接收客户端消息的线程

        public Form1()
        {
            InitializeComponent();

            this.bt_startlisten.Enabled = true;
            this.bt_stoplisten.Enabled = false;
        }


        private void bt_startlisten_Click(object sender, EventArgs e)
        {
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  //创建一个用于监听的socket对象
            IPAddress ip = IPAddress.Parse(this.txb_ip.Text.Trim());
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(this.txb_port.Text.Trim()));  //建立一个端点对象
            socketWatch.Bind(point);   //绑定端点
            this.txt_log.AppendText("监听成功" + " \r\n");
            socketWatch.Listen(10);    //开始帧听，最大接受10个请求

            //实例化回调
            setCallBack = new SetTextValueCallBack(SetTextValue);
            receiveCallBack = new ReceiveMsgCallBack(ReceiveMsg);
            setCmbCallBack = new SetCmbCallBack(AddCmbItem);

            AcceptSocketThread = new Thread(new ParameterizedThreadStart(StartListen));
            AcceptSocketThread.IsBackground = true;  //后台运行
            AcceptSocketThread.Start(socketWatch);   //启动线程，socketWatch作为线程的数据对象
            this.bt_startlisten.Enabled = false;
            this.bt_stoplisten.Enabled = true;
        }


        private void SetTextValue(string strValue)
        {
            this.txt_log.AppendText(strValue + "\r\n");  //更新数据接收窗口
        }

        private void ReceiveMsg(string strMsg)
        {
            string[] sArray;

            sArray = strMsg.Split(' ');

            this.tb_tmp.Text = " " + sArray[0];   //温度显示

//           this.tb_co.Text = " "  + sArray[1];   //CO显示
            this.tb_co.Text = " 0.0";   //CO显示


            this.tb_hum.Text = " " + sArray[2];   //湿度显示

            /* 标准颗粒物 */
            this.PM1_0_CF1.Text = "  " + sArray[3];
            this.PM2_5_CF1.Text = "  " + sArray[4];
　          this.PM10_CF1.Text  = "  " + sArray[5];


            /* 大气环境下 */
            this.PM1_0.Text = "  " + sArray[6];
            this.PM2_5.Text = "  " + sArray[7];
            this.PM10.Text  = "  " + sArray[8];

            /* 0.1升空气中颗粒物的个数 */
            this.tb_0_3um.Text = "   " + sArray[9];
            this.tb_0_5um.Text = "   " + sArray[10];
            this.tb_1_0um.Text = "   " + sArray[11];
            this.tb_2_5um.Text = "   " + sArray[12];
            this.tb_5_0um.Text = "   " + sArray[13];
            this.tb_10_0um.Text = "   " + sArray[14];

         
            int a = Convert.ToInt32(sArray[6]);
            int b = Convert.ToInt32(sArray[7]);
            int c = Convert.ToInt32(sArray[8]);
  //          double d = Convert.ToDouble(sArray[1]);
            double d = 0.0;
            
            if (a > 75)  
                this.pb_pm1.BackgroundImage = Properties.Resources.N;
            else
                this.pb_pm1.BackgroundImage = Properties.Resources.Y;

            if (b > 75)  
                this.pb_pm25.BackgroundImage = Properties.Resources.N;
            else
                this.pb_pm25.BackgroundImage = Properties.Resources.Y;

            if (c > 150)  
                this.pb_pm10.BackgroundImage = Properties.Resources.N;
            else
                this.pb_pm10.BackgroundImage = Properties.Resources.Y;

            if (d > 10.0)
                this.pb_co.BackgroundImage = Properties.Resources.N;
            else
                this.pb_co.BackgroundImage = Properties.Resources.Y;


            this.txt_log.AppendText("接收" + socketSend.RemoteEndPoint + "发送的消息：" + strMsg + "\r\n");  //更新数据接收窗口 
        }

        private void AddCmbItem(string strItem)
        {
            this.cmb_socket.Items.Add(strItem + "\r\n");  //更新远程端口信息
        }

        private void StartListen(object obj)  //传入的对象参数是：socketWatch
        {
            Socket socketWatch = obj as Socket;
            while (true)
            {
                try
                {
                    socketSend = socketWatch.Accept();    //等待客户端连接
                    string strIP = socketSend.RemoteEndPoint.ToString();  //获取远程主机端点
                    dicSocket.Add(strIP, socketSend);     //"远程端点":"Socket"
                    this.cmb_socket.Invoke(setCmbCallBack, strIP);  //cmb_socket中添加当前端点
                    string strMsg = "远程主机：" + socketSend.RemoteEndPoint + " 连接成功";
                    this.txt_log.Invoke(setCallBack, strMsg);       //显示信息

                    threadReceive = new Thread(new ParameterizedThreadStart(Receive));
                    threadReceive.IsBackground = true;  //后台运行
                    threadReceive.Start(socketSend);
                }
                catch
                {
                }
            }
        }

        private void Receive(object obj)  //对象参数是远程端点连接时返回的Socket对象
        {
            Socket socketSend = obj as Socket;

            while (true)
            {
                byte[] buffer = new byte[1024];
                try
                {
                    int count = socketSend.Receive(buffer);  //接收字节数
                    if (count == 0)
                        break;
                    else
                    {
                        string str = Encoding.Default.GetString(buffer, 0, count);
                        this.txt_log.Invoke(receiveCallBack, str);
                    }
                }
                catch
                {
                }
            }
        }

        private void bt_stoplisten_Click(object sender, EventArgs e)
        {
            try
            {
                socketWatch.Close();
                socketSend.Close();
                AcceptSocketThread.Abort();
                threadReceive.Abort();
                this.bt_startlisten.Enabled = true;
                this.bt_stoplisten.Enabled = false;
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_log.Text = "";
        }

    }
}
