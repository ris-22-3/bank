namespace Bank
{
    partial class ATMForm
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
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lHSE = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sumBox = new System.Windows.Forms.TextBox();
            this.button_500rub = new System.Windows.Forms.Button();
            this.button_1000rub = new System.Windows.Forms.Button();
            this.button_5000rub = new System.Windows.Forms.Button();
            this.button_2000rub = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addCash_Button = new System.Windows.Forms.Button();
            this.takeCash_Button = new System.Windows.Forms.Button();
            this.MainTopPanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.MainTopPanel.Controls.Add(this.panel12);
            this.MainTopPanel.Controls.Add(this.panel11);
            this.MainTopPanel.Controls.Add(this.panel10);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(782, 84);
            this.MainTopPanel.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(150, 84);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(346, 0);
            this.panel12.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lHSE);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(150, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(632, 84);
            this.panel11.TabIndex = 4;
            // 
            // lHSE
            // 
            this.lHSE.Dock = System.Windows.Forms.DockStyle.Right;
            this.lHSE.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHSE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lHSE.Location = new System.Drawing.Point(430, 0);
            this.lHSE.Name = "lHSE";
            this.lHSE.Size = new System.Drawing.Size(202, 84);
            this.lHSE.TabIndex = 0;
            this.lHSE.Text = "HSE Bank";
            this.lHSE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(71, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 84);
            this.label7.TabIndex = 0;
            this.label7.Text = "Банкомат";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.BackButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(150, 84);
            this.panel10.TabIndex = 3;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 84);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 469);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Location = new System.Drawing.Point(6, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 236);
            this.panel4.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Sum,
            this.Type});
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(317, 230);
            this.dataGridView.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.FillWeight = 81.54242F;
            this.Data.HeaderText = "Дата";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.FillWeight = 98.1367F;
            this.Sum.HeaderText = "Сумма";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.FillWeight = 120.3208F;
            this.Type.HeaderText = "Тип операции";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Все операции:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 169);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.Balance);
            this.panel5.Location = new System.Drawing.Point(6, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 110);
            this.panel5.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "РУБ",
            "USD",
            "ТГ"});
            this.comboBox1.Location = new System.Drawing.Point(213, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 35);
            this.comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(47, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "HSE-card 12** **** **** ****";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Balance.Location = new System.Drawing.Point(110, 26);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(0, 31);
            this.Balance.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кошелёк:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumBox
            // 
            this.sumBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sumBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumBox.Location = new System.Drawing.Point(64, 28);
            this.sumBox.Multiline = true;
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(326, 60);
            this.sumBox.TabIndex = 3;
            this.sumBox.Text = "Введите сумму или нажмите одну из клавиш ниже";
            // 
            // button_500rub
            // 
            this.button_500rub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.button_500rub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_500rub.FlatAppearance.BorderSize = 0;
            this.button_500rub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_500rub.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_500rub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_500rub.Location = new System.Drawing.Point(375, 219);
            this.button_500rub.Name = "button_500rub";
            this.button_500rub.Size = new System.Drawing.Size(163, 66);
            this.button_500rub.TabIndex = 5;
            this.button_500rub.Text = "500";
            this.button_500rub.UseVisualStyleBackColor = false;
            // 
            // button_1000rub
            // 
            this.button_1000rub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.button_1000rub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_1000rub.FlatAppearance.BorderSize = 0;
            this.button_1000rub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1000rub.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_1000rub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_1000rub.Location = new System.Drawing.Point(580, 219);
            this.button_1000rub.Name = "button_1000rub";
            this.button_1000rub.Size = new System.Drawing.Size(163, 66);
            this.button_1000rub.TabIndex = 6;
            this.button_1000rub.Text = "1000";
            this.button_1000rub.UseVisualStyleBackColor = false;
            // 
            // button_5000rub
            // 
            this.button_5000rub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.button_5000rub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_5000rub.FlatAppearance.BorderSize = 0;
            this.button_5000rub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5000rub.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_5000rub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_5000rub.Location = new System.Drawing.Point(580, 305);
            this.button_5000rub.Name = "button_5000rub";
            this.button_5000rub.Size = new System.Drawing.Size(163, 66);
            this.button_5000rub.TabIndex = 8;
            this.button_5000rub.Text = "5000";
            this.button_5000rub.UseVisualStyleBackColor = false;
            // 
            // button_2000rub
            // 
            this.button_2000rub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.button_2000rub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_2000rub.FlatAppearance.BorderSize = 0;
            this.button_2000rub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2000rub.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_2000rub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_2000rub.Location = new System.Drawing.Point(375, 305);
            this.button_2000rub.Name = "button_2000rub";
            this.button_2000rub.Size = new System.Drawing.Size(163, 66);
            this.button_2000rub.TabIndex = 7;
            this.button_2000rub.Text = "2000";
            this.button_2000rub.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.sumBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(335, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 111);
            this.panel3.TabIndex = 9;
            // 
            // addCash_Button
            // 
            this.addCash_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.addCash_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addCash_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCash_Button.FlatAppearance.BorderSize = 0;
            this.addCash_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCash_Button.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCash_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addCash_Button.Location = new System.Drawing.Point(335, 487);
            this.addCash_Button.Name = "addCash_Button";
            this.addCash_Button.Size = new System.Drawing.Size(447, 66);
            this.addCash_Button.TabIndex = 10;
            this.addCash_Button.Text = "Внести наличные";
            this.addCash_Button.UseVisualStyleBackColor = false;
            // 
            // takeCash_Button
            // 
            this.takeCash_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.takeCash_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.takeCash_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.takeCash_Button.FlatAppearance.BorderSize = 0;
            this.takeCash_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeCash_Button.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.takeCash_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.takeCash_Button.Location = new System.Drawing.Point(335, 421);
            this.takeCash_Button.Name = "takeCash_Button";
            this.takeCash_Button.Size = new System.Drawing.Size(447, 66);
            this.takeCash_Button.TabIndex = 11;
            this.takeCash_Button.Text = "Снять наличные";
            this.takeCash_Button.UseVisualStyleBackColor = false;
            // 
            // ATMForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.takeCash_Button);
            this.Controls.Add(this.addCash_Button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_5000rub);
            this.Controls.Add(this.button_2000rub);
            this.Controls.Add(this.button_1000rub);
            this.Controls.Add(this.button_500rub);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainTopPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ATMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MainTopPanel.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainTopPanel;
        private Panel panel12;
        private Panel panel11;
        private Label lHSE;
        private Label label7;
        private Panel panel10;
        private Button BackButton;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private Panel panel5;
        private Label label6;
        private Label Balance;
        private TextBox sumBox;
        private Button button_500rub;
        private Button button_1000rub;
        private Button button_5000rub;
        private Button button_2000rub;
        private Panel panel4;
        private Panel panel3;
        private Button addCash_Button;
        private Button takeCash_Button;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewTextBoxColumn Type;
        private ComboBox comboBox1;
    }
}