using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;

namespace RandomExtract
{
    public partial class Main : Form
    {
        int[] numFlag = new int[1000];
        int[] nameFlag = new int[1000];
        int numcount = 0;
        int namecount = 0;
        int InfoClickCount = 0;
        public Main()
        {
            InitializeComponent();
        }
        #region UI相关
        //关闭
        private void close_button_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        //最小化到任务栏
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //设置
        private void setting_button_Click(object sender, EventArgs e)
        {
            Setting fsetting = new Setting(this);
            fsetting.ShowDialog();
            Config.GetConfig();
        }

        private void main_lable_Click(object sender, EventArgs e)
        {

        }

        //移动窗口
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        private const int HT_CLIENT = 0x1;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            WndProc(ref msg);
        }

        //鼠标移到设置按钮时显示设置
        private void setting_button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.setting_button, "设置");
        }

        //鼠标移到最小化按钮时显示最小化
        private void minimize_button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.minimize_button, "最小化");
        }

        //鼠标移到关闭按钮时显示关闭
        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.close_button, "关闭");
        }
        #endregion

        #region 启动
        private void Main_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory+@"NameList");
            if (!Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory+@"NameList"))//判断名单路径是否存在
            {
                Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory+@"NameList");
            }
            string info = "";
            Config.GetConfig();
            //右下角信息显示
            switch (Config.Mode)
            {
                case "A1":
                case "A2":
                    info = string.Format("ver 1.0.0.1 ,{0},{1},{2}", Config.Mode, Config.MIN, Config.MAX);//右下角信息
                    info_label.Text = info;
                    break;
                case "B1":
                case "B2":
                    info = string.Format("ver 1.0.0.1 ,{0},{1}", Config.Mode, Config.name.Count);
                    info_label.Text = info;
                    break;
                default:
                    info_label.Text = "ERROR";
                    break;
            }
            //抽号不放回型标志
            for (int i = 0; i <= 999; i++)
            {
                numFlag[i] = 0;
            }
            //点名不放回标志
            for (int i = 0; i <=999; i++)
            {
                nameFlag[i] = 0;
            }
        }
        #endregion

        #region 开始抽号
        private void go_button_Click(object sender, EventArgs e)
        {
            switch (Config.Mode)
            {
                case "A1"://抽号放回型
                    for (int i = 0; i < BaseRandom.GetRandom(10, 15); i++)
                    {
                        main_lable.Text = BaseRandom.GetRandom(Config.MIN, Config.MAX).ToString();
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(100);
                    }
                    break;
                case "A2"://抽号不放回型
                    if (numcount == (Config.MAX - Config.MIN + 1))
                    {
                        MessageBox.Show("所有号码已抽完，即将重置");
                        numcount = 0;
                        for (int i = 0; i <=999; i++)
                        {
                            numFlag[i] = 0;
                        }
                        break;
                    }
                    for (int i = 0; i <= 10; i++)
                    {
                        int num = BaseRandom.GetRandom(Config.MIN, (Config.MAX+1));
                        main_lable.Text = num.ToString();
                        Application.DoEvents();
                        if (i==10)
                        {
                            if (numcount != (Config.MAX - Config.MIN+1))
                            {
                                if (numFlag[num-1] == 1)
                                {
                                    i--;
                                }
                                else
                                {
                                    numcount++;
                                    numFlag[num-1] = 1;
                                }
                            }
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                    break;
                case "B1"://点名放回型
                    if (Config.NameList=="")
                    {
                        break;
                    }
                    for (int i = 0; i < BaseRandom.GetRandom(10, 15); i++)
                    {
                        main_lable.Text = Config.name[BaseRandom.GetRandom(0, Config.name.Count)];
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(100);
                    }
                    break;
                case "B2"://点名不放回型
                    if (Config.NameList == "")
                    {
                        break;
                    }
                    if (namecount == Config.name.Count)
                    {
                        MessageBox.Show("所有人已抽完，即将重置");
                        numcount = 0;
                        for (int i = 0; i <= 999; i++)
                        {
                            nameFlag[i] = 0;
                        }
                        break;
                    }
                    for (int i = 0; i <= 10; i++)
                    {
                        int num = BaseRandom.GetRandom(0, Config.name.Count);
                        main_lable.Text = Config.name[num];
                        Application.DoEvents();
                        if (i == 10)
                        {
                            if (numcount != Config.name.Count)
                            {
                                if (nameFlag[num] == 1)
                                {
                                    i--;
                                }
                                else
                                {
                                    namecount++;
                                    nameFlag[num] = 1;
                                }
                            }
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 彩蛋
        public List<Image> ImgList = new List<Image>();
        public int ImageClickCount = 0;
        public void EasterEgg()
        {
            //将图片载入List
            ImgList.Add(RandomExtract.Properties.Resources.彩蛋图片1);
            ImgList.Add(RandomExtract.Properties.Resources.彩蛋图片2);
            ImgList.Add(RandomExtract.Properties.Resources.彩蛋图片3);
            ImgList.Add(RandomExtract.Properties.Resources.彩蛋图片4);
            ImgList.Add(RandomExtract.Properties.Resources.彩蛋图片5);
            ImgList.Add(RandomExtract.Properties.Resources.彩蛋图片6);
            ImgList.Add(RandomExtract.Properties.Resources.彩蛋图片7);
            ImgList.Add(RandomExtract.Properties.Resources.彩蛋图片8);
            LoadingPanel.Visible = true;
            //假的进度条
            string ProgressBar = "■";
            for (int i = 0; i <= 15; i++)
            {
                ProgressBar = ProgressBar.Insert(0, "■");
                Application.DoEvents();
                System.Threading.Thread.Sleep(150);
                ProgressBarLabel.Text = ProgressBar;
            }
            EasterEggPanel.Visible = true;

        }
        //彩蛋触发
        private void info_label_Click(object sender, EventArgs e)
        {
            InfoClickCount++;
            if (InfoClickCount >= 5)
            {
                InfoClickCount = 0;
                EasterEgg();
            }
        }

        //图片被点击
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ImageClickCount++;
            if (ImageClickCount >= 8)
            {
                Play();
                ImageClickCount = 0;
            }

            pictureBox1.Image = ImgList[ImageClickCount];
        }
        //窗口震动
        private void Play()
        {
            int leftWidth = this.Left; //指定窗体左边值
            int topWidth = this.Top; //指定窗体上边值 


            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    this.Left = this.Left + 10;
                }
                else //否则 
                {
                    this.Left = this.Left - 10;
                }
                if (i % 2 == 0)
                {
                    this.Top = this.Top + 10;
                }
                else//否则 
                {
                    this.Top = this.Top - 10;
                }


                System.Threading.Thread.Sleep(30);//震动频率 
            }


            this.Left = leftWidth;//重设窗体初此左边值 
            this.Top = topWidth; //重设窗体初此上边值 
        }
        //ESC键退出彩蛋
        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                EasterEggPanel.Visible = false;
                LoadingPanel.Visible = false;
            }
        }
        #endregion
    }
}
