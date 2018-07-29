namespace RandomExtract
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.about_Button = new RandomExtract.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.setting_minimize_button = new RandomExtract.ImageButton();
            this.setting_close_button = new RandomExtract.ImageButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Min_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Max_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.setting_apply_button = new System.Windows.Forms.Button();
            this.setting_cancel_button = new System.Windows.Forms.Button();
            this.delete_list_Button = new RandomExtract.ImageButton();
            this.add_list_Button = new RandomExtract.ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.about_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting_minimize_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting_close_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_list_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_list_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.about_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.setting_minimize_button);
            this.panel1.Controls.Add(this.setting_close_button);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // about_Button
            // 
            this.about_Button.BackColor = System.Drawing.Color.Transparent;
            this.about_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.about_Button.DownImage = global::RandomExtract.Properties.Resources.关于;
            this.about_Button.HoverImage = global::RandomExtract.Properties.Resources.关于_悬停;
            this.about_Button.Location = new System.Drawing.Point(314, 15);
            this.about_Button.Name = "about_Button";
            this.about_Button.NormalImage = global::RandomExtract.Properties.Resources.关于;
            this.about_Button.Size = new System.Drawing.Size(24, 23);
            this.about_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.about_Button.TabIndex = 3;
            this.about_Button.TabStop = false;
            this.about_Button.Text = "imageButton1";
            this.about_Button.ToolTipText = null;
            this.about_Button.Click += new System.EventHandler(this.about_Button_Click);
            this.about_Button.MouseEnter += new System.EventHandler(this.about_Button_MouseEnter);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "设置";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // setting_minimize_button
            // 
            this.setting_minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.setting_minimize_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.setting_minimize_button.DownImage = null;
            this.setting_minimize_button.HoverImage = global::RandomExtract.Properties.Resources.最小化_悬停;
            this.setting_minimize_button.Location = new System.Drawing.Point(344, 15);
            this.setting_minimize_button.Name = "setting_minimize_button";
            this.setting_minimize_button.NormalImage = global::RandomExtract.Properties.Resources.最小化;
            this.setting_minimize_button.Size = new System.Drawing.Size(24, 23);
            this.setting_minimize_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setting_minimize_button.TabIndex = 1;
            this.setting_minimize_button.TabStop = false;
            this.setting_minimize_button.Text = "imageButton2";
            this.setting_minimize_button.ToolTipText = null;
            this.setting_minimize_button.MouseEnter += new System.EventHandler(this.setting_minimize_button_MouseEnter);
            // 
            // setting_close_button
            // 
            this.setting_close_button.BackColor = System.Drawing.Color.Transparent;
            this.setting_close_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.setting_close_button.DownImage = global::RandomExtract.Properties.Resources.关闭;
            this.setting_close_button.HoverImage = global::RandomExtract.Properties.Resources.关闭__悬停;
            this.setting_close_button.Location = new System.Drawing.Point(374, 15);
            this.setting_close_button.Name = "setting_close_button";
            this.setting_close_button.NormalImage = global::RandomExtract.Properties.Resources.关闭;
            this.setting_close_button.Size = new System.Drawing.Size(25, 23);
            this.setting_close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setting_close_button.TabIndex = 0;
            this.setting_close_button.TabStop = false;
            this.setting_close_button.Text = "imageButton1";
            this.setting_close_button.ToolTipText = null;
            this.setting_close_button.Click += new System.EventHandler(this.setting_close_button_Click);
            this.setting_close_button.MouseEnter += new System.EventHandler(this.setting_close_button_MouseEnter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.checkBox1.Location = new System.Drawing.Point(158, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 30);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "抽号模式";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.checkBox2.Location = new System.Drawing.Point(283, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 30);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "点名模式";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Min_numericUpDown
            // 
            this.Min_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Min_numericUpDown.Font = new System.Drawing.Font("宋体", 15F);
            this.Min_numericUpDown.Location = new System.Drawing.Point(169, 177);
            this.Min_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Min_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Min_numericUpDown.Name = "Min_numericUpDown";
            this.Min_numericUpDown.Size = new System.Drawing.Size(60, 30);
            this.Min_numericUpDown.TabIndex = 3;
            this.Min_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Max_numericUpDown
            // 
            this.Max_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Max_numericUpDown.Font = new System.Drawing.Font("宋体", 15F);
            this.Max_numericUpDown.Location = new System.Drawing.Point(280, 178);
            this.Max_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Max_numericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Max_numericUpDown.Name = "Max_numericUpDown";
            this.Max_numericUpDown.Size = new System.Drawing.Size(59, 30);
            this.Max_numericUpDown.TabIndex = 4;
            this.Max_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "模式：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.label3.Location = new System.Drawing.Point(240, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "到";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "抽号范围：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.label5.Location = new System.Drawing.Point(30, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "名单：";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 31);
            this.comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.label6.Location = new System.Drawing.Point(30, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "抽取类型：";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.checkBox3.Location = new System.Drawing.Point(159, 103);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(94, 30);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "放回型";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.checkBox4.Location = new System.Drawing.Point(283, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(116, 30);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "不放回型";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // setting_apply_button
            // 
            this.setting_apply_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.setting_apply_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_apply_button.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.setting_apply_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setting_apply_button.Location = new System.Drawing.Point(35, 226);
            this.setting_apply_button.Name = "setting_apply_button";
            this.setting_apply_button.Size = new System.Drawing.Size(134, 36);
            this.setting_apply_button.TabIndex = 13;
            this.setting_apply_button.Text = "应用";
            this.setting_apply_button.UseVisualStyleBackColor = false;
            this.setting_apply_button.Click += new System.EventHandler(this.setting_apply_button_Click);
            // 
            // setting_cancel_button
            // 
            this.setting_cancel_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.setting_cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_cancel_button.Font = new System.Drawing.Font("方正卡通简体", 16F);
            this.setting_cancel_button.Location = new System.Drawing.Point(245, 226);
            this.setting_cancel_button.Name = "setting_cancel_button";
            this.setting_cancel_button.Size = new System.Drawing.Size(134, 36);
            this.setting_cancel_button.TabIndex = 14;
            this.setting_cancel_button.Text = "取消";
            this.setting_cancel_button.UseVisualStyleBackColor = false;
            this.setting_cancel_button.Click += new System.EventHandler(this.setting_cancel_button_Click);
            // 
            // delete_list_Button
            // 
            this.delete_list_Button.BackColor = System.Drawing.Color.Transparent;
            this.delete_list_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete_list_Button.DownImage = global::RandomExtract.Properties.Resources.删除;
            this.delete_list_Button.HoverImage = global::RandomExtract.Properties.Resources.删除_悬停;
            this.delete_list_Button.Location = new System.Drawing.Point(344, 141);
            this.delete_list_Button.Name = "delete_list_Button";
            this.delete_list_Button.NormalImage = global::RandomExtract.Properties.Resources.删除;
            this.delete_list_Button.Size = new System.Drawing.Size(24, 23);
            this.delete_list_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete_list_Button.TabIndex = 16;
            this.delete_list_Button.TabStop = false;
            this.delete_list_Button.Text = "imageButton1";
            this.delete_list_Button.ToolTipText = null;
            this.delete_list_Button.Click += new System.EventHandler(this.delete_list_Button_Click);
            this.delete_list_Button.MouseEnter += new System.EventHandler(this.delete_list_Button_MouseEnter);
            // 
            // add_list_Button
            // 
            this.add_list_Button.BackColor = System.Drawing.Color.Transparent;
            this.add_list_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_list_Button.DownImage = global::RandomExtract.Properties.Resources.添加信息;
            this.add_list_Button.HoverImage = global::RandomExtract.Properties.Resources.添加信息_悬停;
            this.add_list_Button.Location = new System.Drawing.Point(306, 141);
            this.add_list_Button.Name = "add_list_Button";
            this.add_list_Button.NormalImage = global::RandomExtract.Properties.Resources.添加信息;
            this.add_list_Button.Size = new System.Drawing.Size(24, 23);
            this.add_list_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_list_Button.TabIndex = 15;
            this.add_list_Button.TabStop = false;
            this.add_list_Button.Text = "imageButton1";
            this.add_list_Button.ToolTipText = null;
            this.add_list_Button.Click += new System.EventHandler(this.add_list_Button_Click);
            this.add_list_Button.MouseEnter += new System.EventHandler(this.add_list_Button_MouseEnter);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 274);
            this.Controls.Add(this.delete_list_Button);
            this.Controls.Add(this.add_list_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setting_cancel_button);
            this.Controls.Add(this.setting_apply_button);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Max_numericUpDown);
            this.Controls.Add(this.Min_numericUpDown);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.about_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting_minimize_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting_close_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_list_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_list_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ImageButton setting_close_button;
        private ImageButton setting_minimize_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown Min_numericUpDown;
        private System.Windows.Forms.NumericUpDown Max_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button setting_apply_button;
        private System.Windows.Forms.Button setting_cancel_button;
        private ImageButton add_list_Button;
        private ImageButton delete_list_Button;
        private ImageButton about_Button;
    }
}