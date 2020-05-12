using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace svchost
{

    public partial class 我曾踏足山巅 : Form
    {
        
        public 我曾踏足山巅()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //点运行状态监听器
    }
        [System.Runtime.InteropServices.DllImport("user32")]
        //[System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        //private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        //移动鼠标 
        const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //模拟鼠标右键抬起 
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        //模拟鼠标中键抬起 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        //标示是否采用绝对坐标 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public const int KEYEVENTF_KEYUP = 2;

        private void 我曾踏足山巅_Load(object sender, EventArgs e)
        {

            
            





    }
        //Boolean flagg = false;
        long ss = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //开始点击函数
            // int interval = 1;
            timer1.Enabled = true;
            ss = 0;
            // interval = int.Parse(textBox1.Text);
            // int times_Click = 0;
            // interval *= 1000;
            // flagg = !flagg;

            label4.Text = "正在运行中";
               // mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                //Thread.Sleep(interval);
               // times_Click += 1;
               // label6.Text = times_Click.ToString();//未生效
               // textBox1.Text = times_Click.ToString(); //未生效
               // Console.WriteLine(times_Click.ToString());
            
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }  ///最小化设置
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" | textBox1.Text.Trim().Equals(""))
            {
                timer1.Interval = 60000;
            } 
            else
            {
                timer1.Interval = int.Parse(textBox1.Text) * 1000;
            }
            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            keybd_event(Keys.ControlKey, 0, 0, 0);  //按下CTRL
            keybd_event(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);  //松开CTRL
          //  System.Console.WriteLine("too yong too sqmple："+ss.ToString());
            ss += 1;
            label6.Text = ss.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }
    }
   
}
