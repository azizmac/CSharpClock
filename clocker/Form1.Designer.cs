namespace clocker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            sTimeClock = new Label();
            btStart = new Button();
            btStop = new Button();
            msTime = new MaskedTextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            sTimeAlarm = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // sTimeClock
            // 
            sTimeClock.AutoSize = true;
            sTimeClock.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sTimeClock.Location = new Point(190, 105);
            sTimeClock.Name = "sTimeClock";
            sTimeClock.Size = new Size(123, 36);
            sTimeClock.TabIndex = 0;
            sTimeClock.Text = "00:00:00";
            // 
            // btStart
            // 
            btStart.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btStart.Location = new Point(137, 183);
            btStart.Name = "btStart";
            btStart.Size = new Size(233, 28);
            btStart.TabIndex = 1;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btStop.Location = new Point(137, 217);
            btStop.Name = "btStop";
            btStop.Size = new Size(233, 68);
            btStop.TabIndex = 2;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // msTime
            // 
            msTime.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            msTime.Location = new Point(209, 144);
            msTime.Mask = "00:00";
            msTime.Name = "msTime";
            msTime.Size = new Size(86, 33);
            msTime.TabIndex = 3;
            msTime.TextAlign = HorizontalAlignment.Center;
            msTime.ValidatingType = typeof(DateTime);
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // sTimeAlarm
            // 
            sTimeAlarm.AutoSize = true;
            sTimeAlarm.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sTimeAlarm.Location = new Point(208, 139);
            sTimeAlarm.Name = "sTimeAlarm";
            sTimeAlarm.Size = new Size(87, 36);
            sTimeAlarm.TabIndex = 4;
            sTimeAlarm.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(481, 317);
            Controls.Add(msTime);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Controls.Add(sTimeClock);
            Controls.Add(sTimeAlarm);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label sTimeClock;
        private Button btStart;
        private Button btStop;
        private MaskedTextBox msTime;
        private System.Windows.Forms.Timer timer2;
        private Label sTimeAlarm;
    }
}
