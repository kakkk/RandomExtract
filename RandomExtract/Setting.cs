using System;
using System.IO;
using System.Windows.Forms;

namespace RandomExtract
{
    public partial class Setting : Form
    {
        private Main maim;
        public Setting(Main main)
        {
            this.maim = main;
            InitializeComponent();
        }
        #region UI相关
        //窗口移动
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

        //启动设置窗口
        private void Setting_Load(object sender, EventArgs e)
        {
            Config.GetAllNameList();
            Config.GetConfig();
            //按照配置文件显示设置
            switch (Config.Mode)
            {
                case "A1":
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = true;
                    checkBox4.Checked = false;
                    comboBox1.Text = "";
                    break;
                case "A2":
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = true;
                    comboBox1.Text = "";
                    break;
                case "B1":
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox4.Checked = false;
                    comboBox1.Text = Config.NameList;
                    break;
                case "B2":
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                    checkBox3.Checked = false;
                    checkBox4.Checked = true;
                    comboBox1.Text = Config.NameList;
                    break;
            }
            this.Max_numericUpDown.Value = Config.MAX;
            this.Min_numericUpDown.Value = Config.MIN;
            //显示所有名单
            
            
            for (int i = 0; i < Config.AllNameList.Count; i++)
            {
                comboBox1.Items.Add(Config.AllNameList[i]);
            }
            //Config.NameList = comboBox1.Text;
        }

        //鼠标移到添加名单按钮显示添加名单
        private void add_list_Button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.add_list_Button, "添加名单");
        }

        //鼠标移到删除名单按钮显示删除名单
        private void delete_list_Button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.delete_list_Button, "删除名单");
        }

        //鼠标移到最小化按钮显示最小化
        private void setting_minimize_button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.setting_minimize_button, "最小化");
        }

        //鼠标移到最小化按钮显示最小化
        private void setting_close_button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.setting_close_button, "关闭");
        }

        //关闭设置
        private void setting_close_button_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        //把CheckBox变为单选（一开始搞错了！！！我也不想这么干。。。
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox1.Checked;
            if (checkBox1.Checked)
            {
                comboBox1.Text = "";
            }
            else
            {
                comboBox1.Text = Config.NameList;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox2.Checked;
            comboBox1.Text = Config.NameList;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = !checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = !checkBox4.Checked;
        }

        private void about_Button_Click(object sender, EventArgs e)
        {
            About fabout = new About();
            fabout.ShowDialog();
        }

        //鼠标移到关于按钮显示关于
        private void about_Button_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.about_Button, "关于");
        }
        #endregion

        #region 设置和取消
        //设置
        private void setting_apply_button_Click(object sender, EventArgs e)
        {
            int ErrrorFlag = 1;
            for (int i = 0; i < Config.AllNameList.Count; i++)
            {
                if (Config.AllNameList[i] == comboBox1.Text)
                {
                    ErrrorFlag = 0;
                }
            }
            if (ErrrorFlag==1&& comboBox1.Text != "")
            {
                MessageBox.Show("名单不存在，请重新输入或选择！");
                return;
            }
            if (Int32.Parse(this.Min_numericUpDown.Value.ToString())>= Int32.Parse(this.Max_numericUpDown.Value.ToString()))
            {
                MessageBox.Show("最小值不可大于最大值！");
                return;
            }
            if(checkBox1.Checked == true&& checkBox2.Checked == false&& checkBox3.Checked == true&& checkBox4.Checked == false)
            {
                Config.Mode = "A1";
            }else if(checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)
            {
                Config.Mode = "A2";
            }else if(checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false)
            {
                Config.Mode = "B1";
            }else if(checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true)
            {
                Config.Mode = "B2";
            }
            Config.MIN = Int32.Parse(this.Min_numericUpDown.Value.ToString());
            Config.MAX = Int32.Parse(this.Max_numericUpDown.Value.ToString());
            switch (Config.Mode)
            {
                case "A1" :
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = true;
                    checkBox4.Checked = false;
                    break;
                case "A2":
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = true;
                    break;
                case "B1":
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox4.Checked = false;
                    break;
                case "B2":
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                    checkBox3.Checked = false;
                    checkBox4.Checked = true;
                    break;
            }
            Config.NameList = comboBox1.Text;
            Config.SaveSetting();
            Config.GetNameList();
            string info = "";
            switch (Config.Mode)
            {
                case "A1":
                case "A2":
                    info = string.Format("ver {0} ,{1},{2},{3}", Config.Ver,Config.Mode, Config.MIN, Config.MAX);//右下角信息
                    break;
                case "B1":
                case "B2":
                    info = string.Format("ver {0} ,{1},{2}",Config.Ver, Config.Mode, Config.name.Count);
                    break;
                default:
                    info = "ERROR";
                    break;
            }
            this.maim.info_label.Text = info;
            MessageBox.Show("修改成功");
        }
        //取消
        private void setting_cancel_button_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        #endregion

        #region 添加和删除名单
        //添加名单操作
        private void add_list_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "打开名单";
            fdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);   //默认当前桌面路径
            fdlg.Filter = "文本文件(*.txt)|*.txt";
            fdlg.FilterIndex = 0;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = System.IO.Path.GetFullPath(fdlg.FileName);
                string destinationFile = System.AppDomain.CurrentDomain.BaseDirectory + @"NameList\"+System.IO.Path.GetFileNameWithoutExtension(fdlg.FileName);
                bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之
                System.IO.File.Copy(sourceFile, destinationFile, isrewrite);
                Config.GetAllNameList();
                comboBox1.Items.Clear();
                for (int i = 0; i < Config.AllNameList.Count; i++)
                {
                    comboBox1.Items.Add(Config.AllNameList[i]);
                }
                Config.NameList = System.IO.Path.GetFileNameWithoutExtension(fdlg.FileName);
                comboBox1.Text = Config.NameList;
            }
        }
        //删除名单操作
        private void delete_list_Button_Click(object sender, EventArgs e)
        {
            string delet_file_path = System.AppDomain.CurrentDomain.BaseDirectory + @"NameList\"+ comboBox1.Text;
            comboBox1.Text = "";
            File.Delete(delet_file_path);
            Config.GetAllNameList();
            comboBox1.Items.Clear();
            for (int i = 0; i < Config.AllNameList.Count; i++)
            {
                comboBox1.Items.Add(Config.AllNameList[i]);
            }
        }
        #endregion

    }
}