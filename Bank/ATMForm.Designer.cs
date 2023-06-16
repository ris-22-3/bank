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
            MainTopPanel = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            lHSE = new Label();
            label7 = new Label();
            panel10 = new Panel();
            BackButton = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            dataGridView = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            comboBox1 = new ComboBox();
            label6 = new Label();
            Balance = new Label();
            label4 = new Label();
            sumBox = new TextBox();
            button_500rub = new Button();
            button_1000rub = new Button();
            button_5000rub = new Button();
            button_2000rub = new Button();
            panel3 = new Panel();
            addCash_Button = new Button();
            takeCash_Button = new Button();
            MainTopPanel.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // MainTopPanel
            // 
            MainTopPanel.BackColor = Color.FromArgb(16, 45, 105);
            MainTopPanel.Controls.Add(panel12);
            MainTopPanel.Controls.Add(panel11);
            MainTopPanel.Controls.Add(panel10);
            MainTopPanel.Dock = DockStyle.Top;
            MainTopPanel.Location = new Point(0, 0);
            MainTopPanel.Name = "MainTopPanel";
            MainTopPanel.Size = new Size(782, 84);
            MainTopPanel.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(150, 84);
            panel12.Name = "panel12";
            panel12.Size = new Size(346, 0);
            panel12.TabIndex = 5;
            // 
            // panel11
            // 
            panel11.Controls.Add(lHSE);
            panel11.Controls.Add(label7);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(150, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(632, 84);
            panel11.TabIndex = 4;
            // 
            // lHSE
            // 
            lHSE.Dock = DockStyle.Right;
            lHSE.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lHSE.ForeColor = SystemColors.ButtonFace;
            lHSE.Location = new Point(430, 0);
            lHSE.Name = "lHSE";
            lHSE.Size = new Size(202, 84);
            lHSE.TabIndex = 0;
            lHSE.Text = "HSE Bank";
            lHSE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(71, 0);
            label7.Name = "label7";
            label7.Size = new Size(353, 84);
            label7.TabIndex = 0;
            label7.Text = "Банкомат";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.Controls.Add(BackButton);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(150, 84);
            panel10.TabIndex = 3;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(16, 45, 105);
            BackButton.BackgroundImageLayout = ImageLayout.None;
            BackButton.Dock = DockStyle.Fill;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.ButtonFace;
            BackButton.Location = new Point(0, 0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(150, 84);
            BackButton.TabIndex = 2;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 45, 105);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 469);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dataGridView);
            panel4.Location = new Point(6, 221);
            panel4.Name = "panel4";
            panel4.Size = new Size(323, 236);
            panel4.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.MenuBar;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Data, Sum, Type });
            dataGridView.Location = new Point(3, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(317, 230);
            dataGridView.TabIndex = 0;
            // 
            // Data
            // 
            Data.FillWeight = 81.54242F;
            Data.HeaderText = "Дата";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Sum
            // 
            Sum.FillWeight = 98.1367F;
            Sum.HeaderText = "Сумма";
            Sum.MinimumWidth = 6;
            Sum.Name = "Sum";
            Sum.ReadOnly = true;
            // 
            // Type
            // 
            Type.FillWeight = 120.3208F;
            Type.HeaderText = "Тип операции";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 169);
            label1.Name = "label1";
            label1.Size = new Size(335, 38);
            label1.TabIndex = 7;
            label1.Text = "Все операции:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 45, 105);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 169);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(Balance);
            panel5.Location = new Point(6, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 110);
            panel5.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "РУБ", "USD", "ТГ" });
            comboBox1.Location = new Point(213, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 35);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 72);
            label6.Name = "label6";
            label6.Size = new Size(201, 23);
            label6.TabIndex = 1;
            label6.Text = "HSE-card 12** **** **** ****";
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Balance.Location = new Point(110, 26);
            Balance.Name = "Balance";
            Balance.Size = new Size(0, 31);
            Balance.TabIndex = 0;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(335, 38);
            label4.TabIndex = 7;
            label4.Text = "Кошелёк:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sumBox
            // 
            sumBox.BackColor = SystemColors.MenuBar;
            sumBox.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sumBox.Location = new Point(64, 28);
            sumBox.Multiline = true;
            sumBox.Name = "sumBox";
            sumBox.Size = new Size(326, 60);
            sumBox.TabIndex = 3;
            sumBox.Text = "Введите сумму или нажмите одну из клавиш ниже";
            sumBox.TextChanged += sumBox_TextChanged;
            // 
            // button_500rub
            // 
            button_500rub.BackColor = Color.FromArgb(16, 45, 105);
            button_500rub.BackgroundImageLayout = ImageLayout.None;
            button_500rub.FlatAppearance.BorderSize = 0;
            button_500rub.FlatStyle = FlatStyle.Flat;
            button_500rub.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_500rub.ForeColor = SystemColors.ButtonFace;
            button_500rub.Location = new Point(375, 219);
            button_500rub.Name = "button_500rub";
            button_500rub.Size = new Size(163, 66);
            button_500rub.TabIndex = 5;
            button_500rub.Text = "500";
            button_500rub.UseVisualStyleBackColor = false;
            button_500rub.Click += button_500rub_Click;
            // 
            // button_1000rub
            // 
            button_1000rub.BackColor = Color.FromArgb(16, 45, 105);
            button_1000rub.BackgroundImageLayout = ImageLayout.None;
            button_1000rub.FlatAppearance.BorderSize = 0;
            button_1000rub.FlatStyle = FlatStyle.Flat;
            button_1000rub.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_1000rub.ForeColor = SystemColors.ButtonFace;
            button_1000rub.Location = new Point(580, 219);
            button_1000rub.Name = "button_1000rub";
            button_1000rub.Size = new Size(163, 66);
            button_1000rub.TabIndex = 6;
            button_1000rub.Text = "1000";
            button_1000rub.UseVisualStyleBackColor = false;
            button_1000rub.Click += button_1000rub_Click;
            // 
            // button_5000rub
            // 
            button_5000rub.BackColor = Color.FromArgb(16, 45, 105);
            button_5000rub.BackgroundImageLayout = ImageLayout.None;
            button_5000rub.FlatAppearance.BorderSize = 0;
            button_5000rub.FlatStyle = FlatStyle.Flat;
            button_5000rub.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_5000rub.ForeColor = SystemColors.ButtonFace;
            button_5000rub.Location = new Point(580, 305);
            button_5000rub.Name = "button_5000rub";
            button_5000rub.Size = new Size(163, 66);
            button_5000rub.TabIndex = 8;
            button_5000rub.Text = "5000";
            button_5000rub.UseVisualStyleBackColor = false;
            button_5000rub.Click += button_5000rub_Click;
            // 
            // button_2000rub
            // 
            button_2000rub.BackColor = Color.FromArgb(16, 45, 105);
            button_2000rub.BackgroundImageLayout = ImageLayout.None;
            button_2000rub.FlatAppearance.BorderSize = 0;
            button_2000rub.FlatStyle = FlatStyle.Flat;
            button_2000rub.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_2000rub.ForeColor = SystemColors.ButtonFace;
            button_2000rub.Location = new Point(375, 305);
            button_2000rub.Name = "button_2000rub";
            button_2000rub.Size = new Size(163, 66);
            button_2000rub.TabIndex = 7;
            button_2000rub.Text = "2000";
            button_2000rub.UseVisualStyleBackColor = false;
            button_2000rub.Click += button_2000rub_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 45, 105);
            panel3.Controls.Add(sumBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(335, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 111);
            panel3.TabIndex = 9;
            // 
            // addCash_Button
            // 
            addCash_Button.BackColor = Color.FromArgb(16, 45, 105);
            addCash_Button.BackgroundImageLayout = ImageLayout.None;
            addCash_Button.Dock = DockStyle.Bottom;
            addCash_Button.FlatAppearance.BorderSize = 0;
            addCash_Button.FlatStyle = FlatStyle.Flat;
            addCash_Button.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addCash_Button.ForeColor = SystemColors.ButtonFace;
            addCash_Button.Location = new Point(335, 487);
            addCash_Button.Name = "addCash_Button";
            addCash_Button.Size = new Size(447, 66);
            addCash_Button.TabIndex = 10;
            addCash_Button.Text = "Внести наличные";
            addCash_Button.UseVisualStyleBackColor = false;
            addCash_Button.Click += addCash_Button_Click;
            // 
            // takeCash_Button
            // 
            takeCash_Button.BackColor = Color.FromArgb(16, 45, 105);
            takeCash_Button.BackgroundImageLayout = ImageLayout.None;
            takeCash_Button.Dock = DockStyle.Bottom;
            takeCash_Button.FlatAppearance.BorderSize = 0;
            takeCash_Button.FlatStyle = FlatStyle.Flat;
            takeCash_Button.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            takeCash_Button.ForeColor = SystemColors.ButtonFace;
            takeCash_Button.Location = new Point(335, 421);
            takeCash_Button.Name = "takeCash_Button";
            takeCash_Button.Size = new Size(447, 66);
            takeCash_Button.TabIndex = 11;
            takeCash_Button.Text = "Снять наличные";
            takeCash_Button.UseVisualStyleBackColor = false;
            takeCash_Button.Click += takeCash_Button_Click;
            // 
            // ATMForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(782, 553);
            Controls.Add(takeCash_Button);
            Controls.Add(addCash_Button);
            Controls.Add(panel3);
            Controls.Add(button_5000rub);
            Controls.Add(button_2000rub);
            Controls.Add(button_1000rub);
            Controls.Add(button_500rub);
            Controls.Add(panel1);
            Controls.Add(MainTopPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ATMForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            MainTopPanel.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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