namespace WinFormsApp1
{
    partial class FormTowerGame
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
            components = new System.ComponentModel.Container();
            lblCounterSteps = new Label();
            lblIterations = new Label();
            lblTimer = new Label();
            btnIterationTotalDamage = new Label();
            btnIterationTotalTabDefence = new Label();
            btnIterationTotalHealth = new Label();
            btnIterationTotalTabAttack = new Label();
            btnIterationTotalGems = new Label();
            lblIterationCurrentDamage = new Label();
            lblIterationCurrentTabDefence = new Label();
            lblIterationCurrentHealth = new Label();
            lblIterationCurrentTabAttack = new Label();
            lblIterationCurrentGems = new Label();
            btnPause = new Button();
            button1 = new Button();
            txtPostionHealthY = new TextBox();
            txtPostionHealthX = new TextBox();
            label5 = new Label();
            btnStartStop = new Button();
            btnLocationAttackTab = new Button();
            txtPositionTabAttackY = new TextBox();
            txtPositionTabAttackX = new TextBox();
            label4 = new Label();
            btnLocationDefenceTab = new Button();
            txtPositionTabDefenceY = new TextBox();
            txtPositionTabDefanceX = new TextBox();
            label3 = new Label();
            btnLocationDamage = new Button();
            txtPositionDamageY = new TextBox();
            txtPositionDamageX = new TextBox();
            label2 = new Label();
            btnLocationGems = new Button();
            txtPositionGemsY = new TextBox();
            txtPositionGemsX = new TextBox();
            label1 = new Label();
            txtLog = new TextBox();
            timerClicks = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblCounterSteps
            // 
            lblCounterSteps.AutoSize = true;
            lblCounterSteps.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCounterSteps.Location = new Point(397, 216);
            lblCounterSteps.Name = "lblCounterSteps";
            lblCounterSteps.Size = new Size(91, 37);
            lblCounterSteps.TabIndex = 69;
            lblCounterSteps.Text = "0 / 12";
            // 
            // lblIterations
            // 
            lblIterations.AutoSize = true;
            lblIterations.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblIterations.Location = new Point(235, 216);
            lblIterations.Name = "lblIterations";
            lblIterations.Size = new Size(33, 37);
            lblIterations.TabIndex = 68;
            lblIterations.Text = "0";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTimer.Location = new Point(16, 216);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(127, 37);
            lblTimer.TabIndex = 67;
            lblTimer.Text = "00:00:00";
            // 
            // btnIterationTotalDamage
            // 
            btnIterationTotalDamage.AutoSize = true;
            btnIterationTotalDamage.Location = new Point(577, 44);
            btnIterationTotalDamage.Name = "btnIterationTotalDamage";
            btnIterationTotalDamage.Size = new Size(13, 15);
            btnIterationTotalDamage.TabIndex = 66;
            btnIterationTotalDamage.Text = "0";
            // 
            // btnIterationTotalTabDefence
            // 
            btnIterationTotalTabDefence.AutoSize = true;
            btnIterationTotalTabDefence.Location = new Point(577, 77);
            btnIterationTotalTabDefence.Name = "btnIterationTotalTabDefence";
            btnIterationTotalTabDefence.Size = new Size(13, 15);
            btnIterationTotalTabDefence.TabIndex = 65;
            btnIterationTotalTabDefence.Text = "0";
            // 
            // btnIterationTotalHealth
            // 
            btnIterationTotalHealth.AutoSize = true;
            btnIterationTotalHealth.Location = new Point(577, 114);
            btnIterationTotalHealth.Name = "btnIterationTotalHealth";
            btnIterationTotalHealth.Size = new Size(13, 15);
            btnIterationTotalHealth.TabIndex = 64;
            btnIterationTotalHealth.Text = "0";
            // 
            // btnIterationTotalTabAttack
            // 
            btnIterationTotalTabAttack.AutoSize = true;
            btnIterationTotalTabAttack.Location = new Point(577, 145);
            btnIterationTotalTabAttack.Name = "btnIterationTotalTabAttack";
            btnIterationTotalTabAttack.Size = new Size(13, 15);
            btnIterationTotalTabAttack.TabIndex = 63;
            btnIterationTotalTabAttack.Text = "0";
            // 
            // btnIterationTotalGems
            // 
            btnIterationTotalGems.AutoSize = true;
            btnIterationTotalGems.Location = new Point(577, 11);
            btnIterationTotalGems.Name = "btnIterationTotalGems";
            btnIterationTotalGems.Size = new Size(13, 15);
            btnIterationTotalGems.TabIndex = 62;
            btnIterationTotalGems.Text = "0";
            // 
            // lblIterationCurrentDamage
            // 
            lblIterationCurrentDamage.AutoSize = true;
            lblIterationCurrentDamage.Location = new Point(521, 44);
            lblIterationCurrentDamage.Name = "lblIterationCurrentDamage";
            lblIterationCurrentDamage.Size = new Size(13, 15);
            lblIterationCurrentDamage.TabIndex = 61;
            lblIterationCurrentDamage.Text = "0";
            // 
            // lblIterationCurrentTabDefence
            // 
            lblIterationCurrentTabDefence.AutoSize = true;
            lblIterationCurrentTabDefence.Location = new Point(521, 77);
            lblIterationCurrentTabDefence.Name = "lblIterationCurrentTabDefence";
            lblIterationCurrentTabDefence.Size = new Size(13, 15);
            lblIterationCurrentTabDefence.TabIndex = 60;
            lblIterationCurrentTabDefence.Text = "0";
            // 
            // lblIterationCurrentHealth
            // 
            lblIterationCurrentHealth.AutoSize = true;
            lblIterationCurrentHealth.Location = new Point(521, 114);
            lblIterationCurrentHealth.Name = "lblIterationCurrentHealth";
            lblIterationCurrentHealth.Size = new Size(13, 15);
            lblIterationCurrentHealth.TabIndex = 59;
            lblIterationCurrentHealth.Text = "0";
            // 
            // lblIterationCurrentTabAttack
            // 
            lblIterationCurrentTabAttack.AutoSize = true;
            lblIterationCurrentTabAttack.Location = new Point(521, 145);
            lblIterationCurrentTabAttack.Name = "lblIterationCurrentTabAttack";
            lblIterationCurrentTabAttack.Size = new Size(13, 15);
            lblIterationCurrentTabAttack.TabIndex = 58;
            lblIterationCurrentTabAttack.Text = "0";
            // 
            // lblIterationCurrentGems
            // 
            lblIterationCurrentGems.AutoSize = true;
            lblIterationCurrentGems.Location = new Point(521, 11);
            lblIterationCurrentGems.Name = "lblIterationCurrentGems";
            lblIterationCurrentGems.Size = new Size(13, 15);
            lblIterationCurrentGems.TabIndex = 57;
            lblIterationCurrentGems.Text = "0";
            // 
            // btnPause
            // 
            btnPause.Enabled = false;
            btnPause.Location = new Point(272, 181);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(216, 23);
            btnPause.TabIndex = 56;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(380, 105);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 55;
            button1.Text = "Pick location";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtPostionHealthY
            // 
            txtPostionHealthY.Enabled = false;
            txtPostionHealthY.Location = new Point(248, 106);
            txtPostionHealthY.Name = "txtPostionHealthY";
            txtPostionHealthY.Size = new Size(100, 23);
            txtPostionHealthY.TabIndex = 54;
            // 
            // txtPostionHealthX
            // 
            txtPostionHealthX.Enabled = false;
            txtPostionHealthX.Location = new Point(115, 106);
            txtPostionHealthX.Name = "txtPostionHealthX";
            txtPostionHealthX.Size = new Size(100, 23);
            txtPostionHealthX.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 109);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 52;
            label5.Text = "Health";
            // 
            // btnStartStop
            // 
            btnStartStop.Location = new Point(12, 181);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(216, 23);
            btnStartStop.TabIndex = 51;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnLocationAttackTab
            // 
            btnLocationAttackTab.Location = new Point(380, 141);
            btnLocationAttackTab.Name = "btnLocationAttackTab";
            btnLocationAttackTab.Size = new Size(108, 23);
            btnLocationAttackTab.TabIndex = 50;
            btnLocationAttackTab.Text = "Pick location";
            btnLocationAttackTab.UseVisualStyleBackColor = true;
            // 
            // txtPositionTabAttackY
            // 
            txtPositionTabAttackY.Location = new Point(248, 142);
            txtPositionTabAttackY.Name = "txtPositionTabAttackY";
            txtPositionTabAttackY.Size = new Size(100, 23);
            txtPositionTabAttackY.TabIndex = 49;
            // 
            // txtPositionTabAttackX
            // 
            txtPositionTabAttackX.Location = new Point(115, 142);
            txtPositionTabAttackX.Name = "txtPositionTabAttackX";
            txtPositionTabAttackX.Size = new Size(100, 23);
            txtPositionTabAttackX.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 145);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 47;
            label4.Text = "Attack tab";
            // 
            // btnLocationDefenceTab
            // 
            btnLocationDefenceTab.Location = new Point(380, 73);
            btnLocationDefenceTab.Name = "btnLocationDefenceTab";
            btnLocationDefenceTab.Size = new Size(108, 23);
            btnLocationDefenceTab.TabIndex = 46;
            btnLocationDefenceTab.Text = "Pick location";
            btnLocationDefenceTab.UseVisualStyleBackColor = true;
            // 
            // txtPositionTabDefenceY
            // 
            txtPositionTabDefenceY.Location = new Point(248, 74);
            txtPositionTabDefenceY.Name = "txtPositionTabDefenceY";
            txtPositionTabDefenceY.Size = new Size(100, 23);
            txtPositionTabDefenceY.TabIndex = 45;
            // 
            // txtPositionTabDefanceX
            // 
            txtPositionTabDefanceX.Location = new Point(115, 74);
            txtPositionTabDefanceX.Name = "txtPositionTabDefanceX";
            txtPositionTabDefanceX.Size = new Size(100, 23);
            txtPositionTabDefanceX.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 43;
            label3.Text = "Defence tab";
            // 
            // btnLocationDamage
            // 
            btnLocationDamage.Location = new Point(380, 40);
            btnLocationDamage.Name = "btnLocationDamage";
            btnLocationDamage.Size = new Size(108, 23);
            btnLocationDamage.TabIndex = 42;
            btnLocationDamage.Text = "Pick location";
            btnLocationDamage.UseVisualStyleBackColor = true;
            btnLocationDamage.Click += btnLocationDamage_Click;
            // 
            // txtPositionDamageY
            // 
            txtPositionDamageY.Location = new Point(248, 41);
            txtPositionDamageY.Name = "txtPositionDamageY";
            txtPositionDamageY.Size = new Size(100, 23);
            txtPositionDamageY.TabIndex = 41;
            // 
            // txtPositionDamageX
            // 
            txtPositionDamageX.Location = new Point(115, 41);
            txtPositionDamageX.Name = "txtPositionDamageX";
            txtPositionDamageX.Size = new Size(100, 23);
            txtPositionDamageX.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 39;
            label2.Text = "Damage";
            // 
            // btnLocationGems
            // 
            btnLocationGems.Location = new Point(380, 7);
            btnLocationGems.Name = "btnLocationGems";
            btnLocationGems.Size = new Size(108, 23);
            btnLocationGems.TabIndex = 38;
            btnLocationGems.Text = "Pick location";
            btnLocationGems.UseVisualStyleBackColor = true;
            btnLocationGems.Click += btnLocationGems_Click;
            // 
            // txtPositionGemsY
            // 
            txtPositionGemsY.Location = new Point(248, 8);
            txtPositionGemsY.Name = "txtPositionGemsY";
            txtPositionGemsY.Size = new Size(100, 23);
            txtPositionGemsY.TabIndex = 37;
            // 
            // txtPositionGemsX
            // 
            txtPositionGemsX.Location = new Point(115, 8);
            txtPositionGemsX.Name = "txtPositionGemsX";
            txtPositionGemsX.Size = new Size(100, 23);
            txtPositionGemsX.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 35;
            label1.Text = "Gems";
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Segoe UI", 22F);
            txtLog.Location = new Point(16, 266);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(472, 600);
            txtLog.TabIndex = 70;
            // 
            // timerClicks
            // 
            timerClicks.Interval = 5000;
            timerClicks.Tick += timerClicks_Tick;
            // 
            // FormTowerGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 888);
            Controls.Add(txtLog);
            Controls.Add(lblCounterSteps);
            Controls.Add(lblIterations);
            Controls.Add(lblTimer);
            Controls.Add(btnIterationTotalDamage);
            Controls.Add(btnIterationTotalTabDefence);
            Controls.Add(btnIterationTotalHealth);
            Controls.Add(btnIterationTotalTabAttack);
            Controls.Add(btnIterationTotalGems);
            Controls.Add(lblIterationCurrentDamage);
            Controls.Add(lblIterationCurrentTabDefence);
            Controls.Add(lblIterationCurrentHealth);
            Controls.Add(lblIterationCurrentTabAttack);
            Controls.Add(lblIterationCurrentGems);
            Controls.Add(btnPause);
            Controls.Add(button1);
            Controls.Add(txtPostionHealthY);
            Controls.Add(txtPostionHealthX);
            Controls.Add(label5);
            Controls.Add(btnStartStop);
            Controls.Add(btnLocationAttackTab);
            Controls.Add(txtPositionTabAttackY);
            Controls.Add(txtPositionTabAttackX);
            Controls.Add(label4);
            Controls.Add(btnLocationDefenceTab);
            Controls.Add(txtPositionTabDefenceY);
            Controls.Add(txtPositionTabDefanceX);
            Controls.Add(label3);
            Controls.Add(btnLocationDamage);
            Controls.Add(txtPositionDamageY);
            Controls.Add(txtPositionDamageX);
            Controls.Add(label2);
            Controls.Add(btnLocationGems);
            Controls.Add(txtPositionGemsY);
            Controls.Add(txtPositionGemsX);
            Controls.Add(label1);
            Name = "FormTowerGame";
            Text = "FormTowerGame";
            Deactivate += FormTowerGame_Deactivate;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCounterSteps;
        private Label lblIterations;
        private Label lblTimer;
        private Label btnIterationTotalDamage;
        private Label btnIterationTotalTabDefence;
        private Label btnIterationTotalHealth;
        private Label btnIterationTotalTabAttack;
        private Label btnIterationTotalGems;
        private Label lblIterationCurrentDamage;
        private Label lblIterationCurrentTabDefence;
        private Label lblIterationCurrentHealth;
        private Label lblIterationCurrentTabAttack;
        private Label lblIterationCurrentGems;
        private Button btnPause;
        private Button button1;
        private TextBox txtPostionHealthY;
        private TextBox txtPostionHealthX;
        private Label label5;
        private Button btnStartStop;
        private Button btnLocationAttackTab;
        private TextBox txtPositionTabAttackY;
        private TextBox txtPositionTabAttackX;
        private Label label4;
        private Button btnLocationDefenceTab;
        private TextBox txtPositionTabDefenceY;
        private TextBox txtPositionTabDefanceX;
        private Label label3;
        private Button btnLocationDamage;
        private TextBox txtPositionDamageY;
        private TextBox txtPositionDamageX;
        private Label label2;
        private Button btnLocationGems;
        private TextBox txtPositionGemsY;
        private TextBox txtPositionGemsX;
        private Label label1;
        private TextBox txtLog;
        private System.Windows.Forms.Timer timerClicks;
    }
}