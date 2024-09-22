namespace WinFormsApp1
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
            button1 = new Button();
            txtLog = new TextBox();
            txtTimerSeconds = new TextBox();
            label1 = new Label();
            btnSetTimer = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStopTimer = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 75);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(885, 12);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(536, 727);
            txtLog.TabIndex = 1;
            txtLog.TextChanged += textBox1_TextChanged;
            // 
            // txtTimerSeconds
            // 
            txtTimerSeconds.Location = new Point(145, 12);
            txtTimerSeconds.Name = "txtTimerSeconds";
            txtTimerSeconds.Size = new Size(100, 23);
            txtTimerSeconds.TabIndex = 2;
            txtTimerSeconds.Text = "10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Timer (sec)";
            // 
            // btnSetTimer
            // 
            btnSetTimer.Location = new Point(279, 12);
            btnSetTimer.Name = "btnSetTimer";
            btnSetTimer.Size = new Size(75, 23);
            btnSetTimer.TabIndex = 4;
            btnSetTimer.Text = "Set";
            btnSetTimer.UseVisualStyleBackColor = true;
            btnSetTimer.Click += btnSetTimer_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnStopTimer
            // 
            btnStopTimer.Enabled = false;
            btnStopTimer.Location = new Point(380, 12);
            btnStopTimer.Name = "btnStopTimer";
            btnStopTimer.Size = new Size(75, 23);
            btnStopTimer.TabIndex = 5;
            btnStopTimer.Text = "Stop";
            btnStopTimer.UseVisualStyleBackColor = true;
            btnStopTimer.Click += btnStopTimer_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 184);
            button2.Name = "button2";
            button2.Size = new Size(282, 23);
            button2.TabIndex = 6;
            button2.Text = "Click on coords";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 751);
            Controls.Add(button2);
            Controls.Add(btnStopTimer);
            Controls.Add(btnSetTimer);
            Controls.Add(label1);
            Controls.Add(txtTimerSeconds);
            Controls.Add(txtLog);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Deactivate += Form1_Deactivate;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtLog;
        private TextBox txtTimerSeconds;
        private Label label1;
        private Button btnSetTimer;
        private System.Windows.Forms.Timer timer1;
        private Button btnStopTimer;
        private Button button2;
    }
}
