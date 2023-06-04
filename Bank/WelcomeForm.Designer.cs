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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MyAccountsButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.MortgageButton = new System.Windows.Forms.Button();
            this.ATMButton = new System.Windows.Forms.Button();
            this.StatisticButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView_all = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(975, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "HSE Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(287, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(688, 100);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(688, 100);
            this.label2.TabIndex = 3;
            this.label2.Text = "Главная страница";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.UserPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 100);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(104, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 100);
            this.label3.TabIndex = 1;
            this.label3.Text = "Иванов И. И.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BackColor = System.Drawing.Color.White;
            this.UserPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new System.Drawing.Point(0, 0);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(104, 100);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MyAccountsButton);
            this.panel2.Controls.Add(this.DepositButton);
            this.panel2.Controls.Add(this.MortgageButton);
            this.panel2.Controls.Add(this.ATMButton);
            this.panel2.Controls.Add(this.StatisticButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 553);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(22, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 108);
            this.panel5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(99, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "HSE-card 12** **** **** ****";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(121, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "4732,56 ";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кошелёк:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyAccountsButton
            // 
            this.MyAccountsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.MyAccountsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyAccountsButton.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyAccountsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MyAccountsButton.Location = new System.Drawing.Point(0, 178);
            this.MyAccountsButton.Name = "MyAccountsButton";
            this.MyAccountsButton.Size = new System.Drawing.Size(413, 75);
            this.MyAccountsButton.TabIndex = 5;
            this.MyAccountsButton.Text = "Мои счета";
            this.MyAccountsButton.UseVisualStyleBackColor = false;
            this.MyAccountsButton.Click += new System.EventHandler(this.MyAccountsButton_Click_1);
            // 
            // DepositButton
            // 
            this.DepositButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.DepositButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositButton.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DepositButton.Location = new System.Drawing.Point(0, 253);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(413, 75);
            this.DepositButton.TabIndex = 4;
            this.DepositButton.Text = "Депозит";
            this.DepositButton.UseVisualStyleBackColor = false;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // MortgageButton
            // 
            this.MortgageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.MortgageButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MortgageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MortgageButton.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MortgageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MortgageButton.Location = new System.Drawing.Point(0, 328);
            this.MortgageButton.Name = "MortgageButton";
            this.MortgageButton.Size = new System.Drawing.Size(413, 75);
            this.MortgageButton.TabIndex = 3;
            this.MortgageButton.Text = "Ипотека";
            this.MortgageButton.UseVisualStyleBackColor = false;
            this.MortgageButton.Click += new System.EventHandler(this.MortgageButton_Click);
            // 
            // ATMButton
            // 
            this.ATMButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.ATMButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ATMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ATMButton.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ATMButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ATMButton.Location = new System.Drawing.Point(0, 403);
            this.ATMButton.Name = "ATMButton";
            this.ATMButton.Size = new System.Drawing.Size(413, 75);
            this.ATMButton.TabIndex = 2;
            this.ATMButton.Text = "Банкомат";
            this.ATMButton.UseVisualStyleBackColor = false;
            this.ATMButton.Click += new System.EventHandler(this.ATMButton_Click);
            // 
            // StatisticButton
            // 
            this.StatisticButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.StatisticButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatisticButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticButton.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatisticButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StatisticButton.Location = new System.Drawing.Point(0, 478);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(413, 75);
            this.StatisticButton.TabIndex = 1;
            this.StatisticButton.Text = "Статистика";
            this.StatisticButton.UseVisualStyleBackColor = false;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(596, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(427, 220);
            this.panel6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 38);
            this.label7.TabIndex = 7;
            this.label7.Text = "Курсы валют:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel7.Controls.Add(this.dataGridView_all);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(596, 406);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(427, 220);
            this.panel7.TabIndex = 3;
            // 
            // dataGridView_all
            // 
            this.dataGridView_all.AllowUserToAddRows = false;
            this.dataGridView_all.AllowUserToDeleteRows = false;
            this.dataGridView_all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_all.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_all.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Sum,
            this.Type});
            this.dataGridView_all.Location = new System.Drawing.Point(0, 41);
            this.dataGridView_all.Name = "dataGridView_all";
            this.dataGridView_all.ReadOnly = true;
            this.dataGridView_all.RowHeadersVisible = false;
            this.dataGridView_all.RowHeadersWidth = 51;
            this.dataGridView_all.RowTemplate.Height = 29;
            this.dataGridView_all.Size = new System.Drawing.Size(427, 179);
            this.dataGridView_all.TabIndex = 8;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип операции";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(427, 38);
            this.label8.TabIndex = 7;
            this.label8.Text = "Последние операции:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all)).EndInit();
            this.ResumeLayout(false);

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
        private Panel panel6;
        private Label label7;
        private Panel panel7;
        private Label label8;
        private DataGridView dataGridView_all;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewTextBoxColumn Type;
    }
}