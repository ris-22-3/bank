using System.Windows.Forms;

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
            panel5 = new Panel();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            MyAccountsButton = new Button();
            DepositButton = new Button();
            MortgageButton = new Button();
            ATMButton = new Button();
            StatisticButton = new Button();
            panel6 = new Panel();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            panel7 = new Panel();
            dataGridView_all = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            BillType = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            label8 = new Label();
            shopButton = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_all).BeginInit();
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
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(22, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 108);
            panel5.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "РУБ", "USD", "ТГ" });
            comboBox1.Location = new Point(251, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 35);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(61, 57);
            label6.Name = "label6";
            label6.Size = new Size(201, 23);
            label6.TabIndex = 1;
            label6.Text = "HSE-card 12** **** **** ****";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(115, 26);
            label5.Name = "label5";
            label5.Size = new Size(98, 31);
            label5.TabIndex = 0;
            label5.Text = "4732,56 ";
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
            MyAccountsButton.Click += MyAccountsButton_Click;
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
            DepositButton.Click += DepositButton_Click;
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
            MortgageButton.Click += MortgageButton_Click_1;
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
            ATMButton.Click += ATMButton_Click;
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
            StatisticButton.Click += StatisticButton_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(16, 45, 105);
            panel6.Controls.Add(label19);
            panel6.Controls.Add(label18);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(596, 133);
            panel6.Name = "panel6";
            panel6.Size = new Size(427, 220);
            panel6.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(16, 45, 105);
            label19.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(317, 155);
            label19.Name = "label19";
            label19.Size = new Size(71, 41);
            label19.TabIndex = 20;
            label19.Text = "0,18";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(16, 45, 105);
            label18.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(197, 155);
            label18.Name = "label18";
            label18.Size = new Size(71, 41);
            label18.TabIndex = 19;
            label18.Text = "0,19";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(16, 45, 105);
            label17.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(317, 93);
            label17.Name = "label17";
            label17.Size = new Size(86, 41);
            label17.TabIndex = 18;
            label17.Text = "79,71";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(16, 45, 105);
            label16.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(197, 93);
            label16.Name = "label16";
            label16.Size = new Size(86, 41);
            label16.TabIndex = 17;
            label16.Text = "85,22";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Palatino Linotype", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(50, 187);
            label15.Name = "label15";
            label15.Size = new Size(124, 17);
            label15.TabIndex = 16;
            label15.Text = "Казахстанский тенге";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Palatino Linotype", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(49, 120);
            label14.Name = "label14";
            label14.Size = new Size(136, 17);
            label14.TabIndex = 15;
            label14.Text = "Американский доллар";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(48, 155);
            label13.Name = "label13";
            label13.Size = new Size(55, 41);
            label13.TabIndex = 14;
            label13.Text = "ТГ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(16, 45, 105);
            label12.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(48, 88);
            label12.Name = "label12";
            label12.Size = new Size(84, 41);
            label12.TabIndex = 13;
            label12.Text = "USD";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.tenge_sign_icon_198700;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(3, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 37);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.coinicon_114542;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(5, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 37);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(319, 47);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 10;
            label11.Text = "Продать";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(208, 47);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 9;
            label10.Text = "Купить";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(38, 47);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 8;
            label9.Text = "Валюта";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(16, 45, 105);
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(427, 38);
            label7.TabIndex = 7;
            label7.Text = "Курсы валют:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(16, 45, 105);
            panel7.Controls.Add(dataGridView_all);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(596, 406);
            panel7.Name = "panel7";
            panel7.Size = new Size(427, 220);
            panel7.TabIndex = 3;
            // 
            // dataGridView_all
            // 
            dataGridView_all.AllowUserToAddRows = false;
            dataGridView_all.AllowUserToDeleteRows = false;
            dataGridView_all.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_all.BackgroundColor = SystemColors.MenuBar;
            dataGridView_all.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_all.Columns.AddRange(new DataGridViewColumn[] { Date, BillType, Sum, Type });
            dataGridView_all.Location = new Point(0, 41);
            dataGridView_all.Name = "dataGridView_all";
            dataGridView_all.ReadOnly = true;
            dataGridView_all.RowHeadersVisible = false;
            dataGridView_all.RowHeadersWidth = 51;
            dataGridView_all.RowTemplate.Height = 29;
            dataGridView_all.Size = new Size(427, 179);
            dataGridView_all.TabIndex = 8;
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // BillType
            // 
            BillType.HeaderText = "Тип счета";
            BillType.MinimumWidth = 6;
            BillType.Name = "BillType";
            BillType.ReadOnly = true;
            // 
            // Sum
            // 
            Sum.HeaderText = "Сумма";
            Sum.MinimumWidth = 6;
            Sum.Name = "Sum";
            Sum.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Тип операции";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(16, 45, 105);
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(427, 38);
            label8.TabIndex = 7;
            label8.Text = "Последние операции:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shopButton
            // 
            shopButton.BackColor = Color.FromArgb(16, 45, 105);
            shopButton.FlatStyle = FlatStyle.Flat;
            shopButton.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            shopButton.ForeColor = SystemColors.ButtonFace;
            shopButton.Location = new Point(1029, 578);
            shopButton.Name = "shopButton";
            shopButton.Size = new Size(153, 75);
            shopButton.TabIndex = 6;
            shopButton.Text = "Магазин";
            shopButton.UseVisualStyleBackColor = false;
            shopButton.Click += shopButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1182, 653);
            Controls.Add(shopButton);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная страница";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_all).EndInit();
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
        private Label label5;
        private Label label4;
        private Panel panel6;
        private Label label7;
        private Panel panel7;
        private Label label8;
        private DataGridView dataGridView_all;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn BillType;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewTextBoxColumn Type;
        private Label label14;
        private Label label13;
        private Label label12;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label6;
        private ComboBox comboBox1;
        private Button shopButton;
    }
}