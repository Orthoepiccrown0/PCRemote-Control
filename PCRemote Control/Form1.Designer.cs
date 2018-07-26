namespace PCRemote_Control
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screenOff = new System.Windows.Forms.Button();
            this.volume_down = new System.Windows.Forms.Button();
            this.volume_up = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.shutdown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.connection_state = new System.Windows.Forms.Label();
            this.localIP = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.internet_box = new System.Windows.Forms.TextBox();
            this.onStartWindows = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.minimiedWindow = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenOff
            // 
            this.screenOff.Location = new System.Drawing.Point(6, 19);
            this.screenOff.Name = "screenOff";
            this.screenOff.Size = new System.Drawing.Size(70, 23);
            this.screenOff.TabIndex = 0;
            this.screenOff.Text = "Shut off";
            this.screenOff.UseVisualStyleBackColor = true;
            this.screenOff.Click += new System.EventHandler(this.button1_Click);
            // 
            // volume_down
            // 
            this.volume_down.Location = new System.Drawing.Point(6, 19);
            this.volume_down.Name = "volume_down";
            this.volume_down.Size = new System.Drawing.Size(75, 23);
            this.volume_down.TabIndex = 1;
            this.volume_down.Text = "Volume -";
            this.volume_down.UseVisualStyleBackColor = true;
            this.volume_down.Click += new System.EventHandler(this.volume_down_Click);
            // 
            // volume_up
            // 
            this.volume_up.Location = new System.Drawing.Point(87, 19);
            this.volume_up.Name = "volume_up";
            this.volume_up.Size = new System.Drawing.Size(75, 23);
            this.volume_up.TabIndex = 2;
            this.volume_up.Text = "Volume +";
            this.volume_up.UseVisualStyleBackColor = true;
            this.volume_up.Click += new System.EventHandler(this.volume_up_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(6, 19);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(75, 23);
            this.shutdown.TabIndex = 4;
            this.shutdown.Text = "Shut down";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.volume_down);
            this.groupBox1.Controls.Add(this.volume_up);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.screenOff);
            this.groupBox2.Location = new System.Drawing.Point(190, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Screen";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Turn on";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.shutdown);
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 104);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(148, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sleep";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Timer (in sec)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(12, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 75);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Media controls";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(7, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Prev track";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(148, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Stop";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(148, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Next track";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Play/pause";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(6, 98);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(190, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Connect through internet";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(6, 111);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(191, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "Start LAN server";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.connection_state);
            this.groupBox5.Controls.Add(this.localIP);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Location = new System.Drawing.Point(284, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 140);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LAN";
            // 
            // connection_state
            // 
            this.connection_state.BackColor = System.Drawing.SystemColors.Control;
            this.connection_state.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_state.ForeColor = System.Drawing.Color.Red;
            this.connection_state.Location = new System.Drawing.Point(9, 29);
            this.connection_state.Name = "connection_state";
            this.connection_state.Size = new System.Drawing.Size(191, 79);
            this.connection_state.TabIndex = 13;
            this.connection_state.Text = "Disconnected";
            this.connection_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // localIP
            // 
            this.localIP.AutoSize = true;
            this.localIP.Location = new System.Drawing.Point(6, 16);
            this.localIP.Name = "localIP";
            this.localIP.Size = new System.Drawing.Size(73, 13);
            this.localIP.TabIndex = 12;
            this.localIP.Text = "Your local IP: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.internet_box);
            this.groupBox6.Controls.Add(this.button10);
            this.groupBox6.Location = new System.Drawing.Point(283, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 127);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Internet";
            // 
            // internet_box
            // 
            this.internet_box.Enabled = false;
            this.internet_box.Location = new System.Drawing.Point(6, 19);
            this.internet_box.Multiline = true;
            this.internet_box.Name = "internet_box";
            this.internet_box.ReadOnly = true;
            this.internet_box.Size = new System.Drawing.Size(190, 73);
            this.internet_box.TabIndex = 12;
            this.internet_box.Text = "Available in the future..";
            // 
            // onStartWindows
            // 
            this.onStartWindows.AutoSize = true;
            this.onStartWindows.Location = new System.Drawing.Point(18, 285);
            this.onStartWindows.Name = "onStartWindows";
            this.onStartWindows.Size = new System.Drawing.Size(171, 17);
            this.onStartWindows.TabIndex = 13;
            this.onStartWindows.Text = "Start PCRemote with Windows";
            this.onStartWindows.UseVisualStyleBackColor = true;
            this.onStartWindows.CheckedChanged += new System.EventHandler(this.onStartWindows_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Working in background";
            this.notifyIcon1.BalloonTipTitle = "Info";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PCRemote Control";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // minimiedWindow
            // 
            this.minimiedWindow.AutoSize = true;
            this.minimiedWindow.Location = new System.Drawing.Point(407, 285);
            this.minimiedWindow.Name = "minimiedWindow";
            this.minimiedWindow.Size = new System.Drawing.Size(72, 17);
            this.minimiedWindow.TabIndex = 14;
            this.minimiedWindow.Text = "Minimized";
            this.minimiedWindow.UseVisualStyleBackColor = true;
            this.minimiedWindow.CheckedChanged += new System.EventHandler(this.minimiedWindow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 304);
            this.Controls.Add(this.minimiedWindow);
            this.Controls.Add(this.onStartWindows);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PC Remote Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button screenOff;
        private System.Windows.Forms.Button volume_down;
        private System.Windows.Forms.Button volume_up;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox internet_box;
        private System.Windows.Forms.Label localIP;
        private System.Windows.Forms.CheckBox onStartWindows;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox minimiedWindow;
        private System.Windows.Forms.Label connection_state;
    }
}

