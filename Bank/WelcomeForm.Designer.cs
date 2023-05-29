namespace Bank
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            panel1 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            UserPictureBox = new PictureBox();
            panel2 = new Panel();
            StatisticButton = new Button();
            ATMButton = new Button();
            MortgageButton = new Button();
            DepositButton = new Button();
            MyAccountsButton = new Button();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 45, 105);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(975, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 100);
            label1.TabIndex = 2;
            label1.Text = "HSE Bank";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(287, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(688, 100);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(688, 100);
            label2.TabIndex = 3;
            label2.Text = "Главная страница";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(UserPictureBox);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(287, 100);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(104, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 100);
            label3.TabIndex = 1;
            label3.Text = "Иванов И. И.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserPictureBox
            // 
            UserPictureBox.BackColor = Color.White;
            UserPictureBox.Dock = DockStyle.Left;
            UserPictureBox.Image = (Image)resources.GetObject("UserPictureBox.Image");
            UserPictureBox.Location = new Point(0, 0);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(104, 100);
            UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPictureBox.TabIndex = 0;
            UserPictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 45, 105);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(MyAccountsButton);
            panel2.Controls.Add(DepositButton);
            panel2.Controls.Add(MortgageButton);
            panel2.Controls.Add(ATMButton);
            panel2.Controls.Add(StatisticButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 553);
            panel2.TabIndex = 1;
            // 
            // StatisticButton
            // 
            StatisticButton.BackColor = Color.FromArgb(16, 45, 105);
            StatisticButton.Dock = DockStyle.Bottom;
            StatisticButton.FlatStyle = FlatStyle.Flat;
            StatisticButton.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            StatisticButton.ForeColor = SystemColors.ButtonFace;
            StatisticButton.Location = new Point(0, 478);
            StatisticButton.Name = "StatisticButton";
            StatisticButton.Size = new Size(413, 75);
            StatisticButton.TabIndex = 1;
            StatisticButton.Text = "Статистика";
            StatisticButton.UseVisualStyleBackColor = false;
            // 
            // ATMButton
            // 
            ATMButton.BackColor = Color.FromArgb(16, 45, 105);
            ATMButton.Dock = DockStyle.Bottom;
            ATMButton.FlatStyle = FlatStyle.Flat;
            ATMButton.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ATMButton.ForeColor = SystemColors.ButtonFace;
            ATMButton.Location = new Point(0, 403);
            ATMButton.Name = "ATMButton";
            ATMButton.Size = new Size(413, 75);
            ATMButton.TabIndex = 2;
            ATMButton.Text = "Банкомат";
            ATMButton.UseVisualStyleBackColor = false;
            // 
            // MortgageButton
            // 
            MortgageButton.BackColor = Color.FromArgb(16, 45, 105);
            MortgageButton.Dock = DockStyle.Bottom;
            MortgageButton.FlatStyle = FlatStyle.Flat;
            MortgageButton.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MortgageButton.ForeColor = SystemColors.ButtonFace;
            MortgageButton.Location = new Point(0, 328);
            MortgageButton.Name = "MortgageButton";
            MortgageButton.Size = new Size(413, 75);
            MortgageButton.TabIndex = 3;
            MortgageButton.Text = "Ипотека";
            MortgageButton.UseVisualStyleBackColor = false;
            // 
            // DepositButton
            // 
            DepositButton.BackColor = Color.FromArgb(16, 45, 105);
            DepositButton.Dock = DockStyle.Bottom;
            DepositButton.FlatStyle = FlatStyle.Flat;
            DepositButton.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DepositButton.ForeColor = SystemColors.ButtonFace;
            DepositButton.Location = new Point(0, 253);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(413, 75);
            DepositButton.TabIndex = 4;
            DepositButton.Text = "Депозит";
            DepositButton.UseVisualStyleBackColor = false;
            // 
            // MyAccountsButton
            // 
            MyAccountsButton.BackColor = Color.FromArgb(16, 45, 105);
            MyAccountsButton.Dock = DockStyle.Bottom;
            MyAccountsButton.FlatStyle = FlatStyle.Flat;
            MyAccountsButton.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MyAccountsButton.ForeColor = SystemColors.ButtonFace;
            MyAccountsButton.Location = new Point(0, 178);
            MyAccountsButton.Name = "MyAccountsButton";
            MyAccountsButton.Size = new Size(413, 75);
            MyAccountsButton.TabIndex = 5;
            MyAccountsButton.Text = "Мои счета";
            MyAccountsButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(413, 38);
            label4.TabIndex = 6;
            label4.Text = "Кошелёк:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(22, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 108);
            panel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(121, 26);
            label5.Name = "label5";
            label5.Size = new Size(98, 31);
            label5.TabIndex = 0;
            label5.Text = "4732,56 ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(99, 57);
            label6.Name = "label6";
            label6.Size = new Size(201, 23);
            label6.TabIndex = 1;
            label6.Text = "HSE-card 12** **** **** ****";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WelcomeForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private PictureBox UserPictureBox;
        private Label label3;
        private Button MyAccountsButton;
        private Button DepositButton;
        private Button MortgageButton;
        private Button ATMButton;
        private Button StatisticButton;
        private Panel panel5;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}