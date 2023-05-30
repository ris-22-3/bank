﻿namespace WinFormsTest
{
    partial class Mortgage
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
            lHSE = new Label();
            panel11 = new Panel();
            label7 = new Label();
            panel10 = new Panel();
            BackButton = new Button();
            label2 = new Label();
            panel2 = new Panel();
            bAccept = new Button();
            panel6 = new Panel();
            label9 = new Label();
            lTerm = new Label();
            tbTerm = new TrackBar();
            label6 = new Label();
            panel5 = new Panel();
            lInitialFee = new Label();
            tbInitialFee = new TrackBar();
            label5 = new Label();
            panel4 = new Panel();
            lPrice = new Label();
            tbPrice = new TrackBar();
            label4 = new Label();
            panel3 = new Panel();
            cbApartmentType = new ComboBox();
            label3 = new Label();
            bPaymentShedule = new Button();
            bApply = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label8 = new Label();
            MainTopPanel.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTerm).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbInitialFee).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPrice).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
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
            MainTopPanel.Size = new Size(1182, 84);
            MainTopPanel.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(lHSE);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(859, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(346, 84);
            panel12.TabIndex = 5;
            // 
            // lHSE
            // 
            lHSE.Dock = DockStyle.Fill;
            lHSE.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lHSE.ForeColor = SystemColors.ButtonFace;
            lHSE.Location = new Point(0, 0);
            lHSE.Name = "lHSE";
            lHSE.Size = new Size(346, 84);
            lHSE.TabIndex = 0;
            lHSE.Text = "HSE Bank";
            lHSE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.Controls.Add(label7);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(150, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(709, 84);
            panel11.TabIndex = 4;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(709, 84);
            label7.TabIndex = 0;
            label7.Text = "Ипотечное кредитование";
            label7.TextAlign = ContentAlignment.MiddleRight;
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
            // label2
            // 
            label2.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(30, -29);
            label2.Name = "label2";
            label2.Size = new Size(416, 40);
            label2.TabIndex = 1;
            label2.Text = "Ипотечное кредитование";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 74, 154);
            panel2.Controls.Add(bAccept);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 569);
            panel2.TabIndex = 1;
            // 
            // bAccept
            // 
            bAccept.BackColor = Color.FromArgb(16, 45, 105);
            bAccept.BackgroundImageLayout = ImageLayout.None;
            bAccept.FlatAppearance.BorderSize = 0;
            bAccept.FlatStyle = FlatStyle.Flat;
            bAccept.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bAccept.ForeColor = SystemColors.ButtonFace;
            bAccept.Location = new Point(98, 497);
            bAccept.Name = "bAccept";
            bAccept.Size = new Size(210, 60);
            bAccept.TabIndex = 4;
            bAccept.Text = "Подтвердить";
            bAccept.UseVisualStyleBackColor = false;
            bAccept.Click += bAccept_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label9);
            panel6.Controls.Add(lTerm);
            panel6.Controls.Add(tbTerm);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 360);
            panel6.Name = "panel6";
            panel6.Size = new Size(419, 120);
            panel6.TabIndex = 3;
            // 
            // label9
            // 
            label9.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(280, -21);
            label9.Name = "label9";
            label9.Size = new Size(33, 21);
            label9.TabIndex = 5;
            label9.Text = "1";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lTerm
            // 
            lTerm.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lTerm.ForeColor = SystemColors.ButtonFace;
            lTerm.Location = new Point(194, 32);
            lTerm.Name = "lTerm";
            lTerm.Size = new Size(82, 21);
            lTerm.TabIndex = 4;
            lTerm.Text = "1 год";
            lTerm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbTerm
            // 
            tbTerm.AutoSize = false;
            tbTerm.Cursor = Cursors.Hand;
            tbTerm.Dock = DockStyle.Bottom;
            tbTerm.LargeChange = 1;
            tbTerm.Location = new Point(0, 72);
            tbTerm.Maximum = 30;
            tbTerm.Minimum = 1;
            tbTerm.Name = "tbTerm";
            tbTerm.Size = new Size(419, 48);
            tbTerm.TabIndex = 3;
            tbTerm.TickStyle = TickStyle.TopLeft;
            tbTerm.Value = 1;
            tbTerm.Scroll += tbTerm_Scroll;
            // 
            // label6
            // 
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(38, 28);
            label6.Name = "label6";
            label6.Size = new Size(150, 24);
            label6.TabIndex = 1;
            label6.Text = "Срок кредита:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(lInitialFee);
            panel5.Controls.Add(tbInitialFee);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 240);
            panel5.Name = "panel5";
            panel5.Size = new Size(419, 120);
            panel5.TabIndex = 2;
            // 
            // lInitialFee
            // 
            lInitialFee.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lInitialFee.ForeColor = SystemColors.ButtonFace;
            lInitialFee.Location = new Point(314, 30);
            lInitialFee.Name = "lInitialFee";
            lInitialFee.Size = new Size(101, 21);
            lInitialFee.TabIndex = 6;
            lInitialFee.Text = "500 тыс. ₽";
            lInitialFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbInitialFee
            // 
            tbInitialFee.AutoSize = false;
            tbInitialFee.Dock = DockStyle.Bottom;
            tbInitialFee.Location = new Point(0, 76);
            tbInitialFee.Maximum = 45;
            tbInitialFee.Minimum = 5;
            tbInitialFee.Name = "tbInitialFee";
            tbInitialFee.Size = new Size(419, 44);
            tbInitialFee.TabIndex = 2;
            tbInitialFee.TickStyle = TickStyle.TopLeft;
            tbInitialFee.Value = 5;
            tbInitialFee.Scroll += tbInitialFee_Scroll;
            // 
            // label5
            // 
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(38, 30);
            label5.Name = "label5";
            label5.Size = new Size(238, 25);
            label5.TabIndex = 1;
            label5.Text = "Первоначальный взнос:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(lPrice);
            panel4.Controls.Add(tbPrice);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(419, 120);
            panel4.TabIndex = 1;
            // 
            // lPrice
            // 
            lPrice.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lPrice.ForeColor = SystemColors.ButtonFace;
            lPrice.Location = new Point(314, 29);
            lPrice.Name = "lPrice";
            lPrice.Size = new Size(101, 21);
            lPrice.TabIndex = 5;
            lPrice.Text = "500 тыс. ₽";
            lPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPrice
            // 
            tbPrice.AutoSize = false;
            tbPrice.Dock = DockStyle.Bottom;
            tbPrice.LargeChange = 1;
            tbPrice.Location = new Point(0, 79);
            tbPrice.Maximum = 450;
            tbPrice.Minimum = 5;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(419, 41);
            tbPrice.SmallChange = 2;
            tbPrice.TabIndex = 3;
            tbPrice.TickFrequency = 10;
            tbPrice.TickStyle = TickStyle.TopLeft;
            tbPrice.Value = 5;
            tbPrice.Scroll += tbPrice_Scroll;
            // 
            // label4
            // 
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(38, 25);
            label4.Name = "label4";
            label4.Size = new Size(270, 25);
            label4.TabIndex = 1;
            label4.Text = "Стоимость недвижимости:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbApartmentType);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 120);
            panel3.TabIndex = 0;
            // 
            // cbApartmentType
            // 
            cbApartmentType.BackColor = Color.FromArgb(16, 45, 105);
            cbApartmentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbApartmentType.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbApartmentType.ForeColor = SystemColors.ButtonFace;
            cbApartmentType.FormattingEnabled = true;
            cbApartmentType.Items.AddRange(new object[] { "Квартира", "Дом", "Гараж", "Коммерческая недвижимость" });
            cbApartmentType.Location = new Point(70, 54);
            cbApartmentType.Name = "cbApartmentType";
            cbApartmentType.Size = new Size(286, 35);
            cbApartmentType.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 14);
            label3.Name = "label3";
            label3.Size = new Size(419, 25);
            label3.TabIndex = 0;
            label3.Text = "Тип недвижимости";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bPaymentShedule
            // 
            bPaymentShedule.BackColor = Color.FromArgb(16, 45, 105);
            bPaymentShedule.BackgroundImageLayout = ImageLayout.None;
            bPaymentShedule.Dock = DockStyle.Fill;
            bPaymentShedule.FlatAppearance.BorderSize = 0;
            bPaymentShedule.FlatStyle = FlatStyle.Flat;
            bPaymentShedule.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bPaymentShedule.ForeColor = SystemColors.ButtonFace;
            bPaymentShedule.Location = new Point(0, 0);
            bPaymentShedule.Name = "bPaymentShedule";
            bPaymentShedule.Size = new Size(763, 42);
            bPaymentShedule.TabIndex = 3;
            bPaymentShedule.Text = "График платежей";
            bPaymentShedule.UseVisualStyleBackColor = false;
            // 
            // bApply
            // 
            bApply.BackColor = Color.FromArgb(16, 45, 105);
            bApply.BackgroundImageLayout = ImageLayout.None;
            bApply.Dock = DockStyle.Fill;
            bApply.FlatAppearance.BorderSize = 0;
            bApply.FlatStyle = FlatStyle.Flat;
            bApply.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bApply.ForeColor = SystemColors.ButtonFace;
            bApply.Location = new Point(0, 0);
            bApply.Name = "bApply";
            bApply.Size = new Size(763, 42);
            bApply.TabIndex = 4;
            bApply.Text = "Подать заявку";
            bApply.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(419, 611);
            panel7.Name = "panel7";
            panel7.Size = new Size(763, 42);
            panel7.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.Controls.Add(bApply);
            panel8.Controls.Add(label2);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(763, 42);
            panel8.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.Controls.Add(bPaymentShedule);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(419, 569);
            panel9.Name = "panel9";
            panel9.Size = new Size(763, 42);
            panel9.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(535, 126);
            label8.Name = "label8";
            label8.Size = new Size(188, 20);
            label8.TabIndex = 7;
            label8.Text = "Данные о недвижимсоти:";
            // 
            // Mortgage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(label8);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(MainTopPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mortgage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSE Bank";
            MainTopPanel.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbTerm).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbInitialFee).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbPrice).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainTopPanel;
        private Label label2;
        private Label lHSE;
        private Button BackButton;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TrackBar tbInitialFee;
        private ComboBox cbApartmentType;
        private Panel panel11;
        private Panel panel10;
        private Button bPaymentShedule;
        private Button bApply;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel12;
        private Label label7;
        private TrackBar tbTerm;
        private TrackBar tbPrice;
        private Button bAccept;
        private Label label8;
        private Label lTerm;
        private Label label9;
        private Label lPrice;
        private Label lInitialFee;
    }
}