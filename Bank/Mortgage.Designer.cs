namespace WinFormsTest
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
            panel1 = new Panel();
            panel15 = new Panel();
            NecessaryIncomeLabel = new Label();
            label11 = new Label();
            panel14 = new Panel();
            MonthlyPaymentLabel = new Label();
            label10 = new Label();
            panel13 = new Panel();
            InterestRateLable = new Label();
            label1 = new Label();
            PaymentSheduleDGV = new DataGridView();
            Year = new DataGridViewTextBoxColumn();
            Month = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            RemainingPayment = new DataGridViewTextBoxColumn();
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
            panel1.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentSheduleDGV).BeginInit();
            SuspendLayout();
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
            this.MainTopPanel.Size = new System.Drawing.Size(1182, 84);
            this.MainTopPanel.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lHSE);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(859, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(346, 84);
            this.panel12.TabIndex = 5;
            // 
            // lHSE
            // 
            this.lHSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lHSE.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHSE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lHSE.Location = new System.Drawing.Point(0, 0);
            this.lHSE.Name = "lHSE";
            this.lHSE.Size = new System.Drawing.Size(346, 84);
            this.lHSE.TabIndex = 0;
            this.lHSE.Text = "HSE Bank";
            this.lHSE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label7);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(150, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(709, 84);
            this.panel11.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(709, 84);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ипотечное кредитование";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, -29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ипотечное кредитование";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(74)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.bAccept);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 621);
            this.panel2.TabIndex = 1;
            // 
            // bAccept
            // 
            this.bAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.bAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bAccept.FlatAppearance.BorderSize = 0;
            this.bAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAccept.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAccept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bAccept.Location = new System.Drawing.Point(98, 497);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(210, 60);
            this.bAccept.TabIndex = 4;
            this.bAccept.Text = "Подтвердить";
            this.bAccept.UseVisualStyleBackColor = false;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.lTerm);
            this.panel6.Controls.Add(this.tbTerm);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(419, 120);
            this.panel6.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(280, -21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lTerm
            // 
            this.lTerm.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTerm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTerm.Location = new System.Drawing.Point(194, 32);
            this.lTerm.Name = "lTerm";
            this.lTerm.Size = new System.Drawing.Size(82, 21);
            this.lTerm.TabIndex = 4;
            this.lTerm.Text = "1 год";
            this.lTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTerm
            // 
            this.tbTerm.AutoSize = false;
            this.tbTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbTerm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbTerm.LargeChange = 1;
            this.tbTerm.Location = new System.Drawing.Point(0, 72);
            this.tbTerm.Maximum = 30;
            this.tbTerm.Minimum = 1;
            this.tbTerm.Name = "tbTerm";
            this.tbTerm.Size = new System.Drawing.Size(419, 48);
            this.tbTerm.TabIndex = 3;
            this.tbTerm.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbTerm.Value = 1;
            this.tbTerm.Scroll += new System.EventHandler(this.tbTerm_Scroll_1);
            this.tbTerm.ValueChanged += new System.EventHandler(this.tbTerm_ValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(38, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Срок кредита:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lInitialFee);
            this.panel5.Controls.Add(this.tbInitialFee);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(419, 120);
            this.panel5.TabIndex = 2;
            // 
            // lInitialFee
            // 
            this.lInitialFee.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lInitialFee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lInitialFee.Location = new System.Drawing.Point(314, 30);
            this.lInitialFee.Name = "lInitialFee";
            this.lInitialFee.Size = new System.Drawing.Size(101, 21);
            this.lInitialFee.TabIndex = 6;
            this.lInitialFee.Text = "500 тыс. ₽";
            this.lInitialFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInitialFee
            // 
            this.tbInitialFee.AutoSize = false;
            this.tbInitialFee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbInitialFee.Location = new System.Drawing.Point(0, 76);
            this.tbInitialFee.Maximum = 90;
            this.tbInitialFee.Minimum = 10;
            this.tbInitialFee.Name = "tbInitialFee";
            this.tbInitialFee.Size = new System.Drawing.Size(419, 44);
            this.tbInitialFee.TabIndex = 2;
            this.tbInitialFee.TickFrequency = 2;
            this.tbInitialFee.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbInitialFee.Value = 10;
            this.tbInitialFee.Scroll += new System.EventHandler(this.tbInitialFee_Scroll_1);
            this.tbInitialFee.ValueChanged += new System.EventHandler(this.tbInitialFee_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(38, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Первоначальный взнос:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lPrice);
            this.panel4.Controls.Add(this.tbPrice);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 120);
            this.panel4.TabIndex = 1;
            // 
            // lPrice
            // 
            this.lPrice.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lPrice.Location = new System.Drawing.Point(314, 29);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(101, 21);
            this.lPrice.TabIndex = 5;
            this.lPrice.Text = "500 тыс. ₽";
            this.lPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrice
            // 
            this.tbPrice.AutoSize = false;
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPrice.LargeChange = 1;
            this.tbPrice.Location = new System.Drawing.Point(0, 79);
            this.tbPrice.Maximum = 500;
            this.tbPrice.Minimum = 5;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(419, 41);
            this.tbPrice.SmallChange = 2;
            this.tbPrice.TabIndex = 3;
            this.tbPrice.TickFrequency = 10;
            this.tbPrice.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbPrice.Value = 5;
            this.tbPrice.Scroll += new System.EventHandler(this.tbPrice_Scroll_1);
            this.tbPrice.ValueChanged += new System.EventHandler(this.tbPrice_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(38, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Стоимость недвижимости:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbApartmentType);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 120);
            this.panel3.TabIndex = 0;
            // 
            // cbApartmentType
            // 
            this.cbApartmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.cbApartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApartmentType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbApartmentType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbApartmentType.FormattingEnabled = true;
            this.cbApartmentType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Гараж",
            "Коммерческая недвижимость"});
            this.cbApartmentType.Location = new System.Drawing.Point(70, 54);
            this.cbApartmentType.Name = "cbApartmentType";
            this.cbApartmentType.Size = new System.Drawing.Size(286, 35);
            this.cbApartmentType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(0, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип недвижимости";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bPaymentShedule
            // 
            this.bPaymentShedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.bPaymentShedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bPaymentShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPaymentShedule.FlatAppearance.BorderSize = 0;
            this.bPaymentShedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPaymentShedule.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPaymentShedule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bPaymentShedule.Location = new System.Drawing.Point(0, 0);
            this.bPaymentShedule.Name = "bPaymentShedule";
            this.bPaymentShedule.Size = new System.Drawing.Size(763, 42);
            this.bPaymentShedule.TabIndex = 3;
            this.bPaymentShedule.Text = "График платежей";
            this.bPaymentShedule.UseVisualStyleBackColor = false;
            this.bPaymentShedule.Click += new System.EventHandler(this.bPaymentShedule_Click_1);
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.bApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bApply.FlatAppearance.BorderSize = 0;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bApply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bApply.Location = new System.Drawing.Point(0, 0);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(763, 42);
            this.bApply.TabIndex = 4;
            this.bApply.Text = "Подать заявку";
            this.bApply.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(419, 663);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(763, 42);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.bApply);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(763, 42);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.bPaymentShedule);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(419, 621);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(763, 42);
            this.panel9.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(74)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(419, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 120);
            this.panel1.TabIndex = 8;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.NecessaryIncomeLabel);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(510, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(263, 120);
            this.panel15.TabIndex = 2;
            // 
            // NecessaryIncomeLabel
            // 
            this.NecessaryIncomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NecessaryIncomeLabel.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NecessaryIncomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NecessaryIncomeLabel.Location = new System.Drawing.Point(0, 38);
            this.NecessaryIncomeLabel.Name = "NecessaryIncomeLabel";
            this.NecessaryIncomeLabel.Size = new System.Drawing.Size(263, 82);
            this.NecessaryIncomeLabel.TabIndex = 9;
            this.NecessaryIncomeLabel.Text = "0 ₽";
            this.NecessaryIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 38);
            this.label11.TabIndex = 8;
            this.label11.Text = "Необходимый доход";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.MonthlyPaymentLabel);
            this.panel14.Controls.Add(this.label10);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(250, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(260, 120);
            this.panel14.TabIndex = 1;
            // 
            // MonthlyPaymentLabel
            // 
            this.MonthlyPaymentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlyPaymentLabel.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthlyPaymentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MonthlyPaymentLabel.Location = new System.Drawing.Point(0, 38);
            this.MonthlyPaymentLabel.Name = "MonthlyPaymentLabel";
            this.MonthlyPaymentLabel.Size = new System.Drawing.Size(260, 82);
            this.MonthlyPaymentLabel.TabIndex = 9;
            this.MonthlyPaymentLabel.Text = "0 ₽";
            this.MonthlyPaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 38);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ежемесячный платёж";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.InterestRateLable);
            this.panel13.Controls.Add(this.label1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(250, 120);
            this.panel13.TabIndex = 0;
            // 
            // InterestRateLable
            // 
            this.InterestRateLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InterestRateLable.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InterestRateLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InterestRateLable.Location = new System.Drawing.Point(0, 38);
            this.InterestRateLable.Name = "InterestRateLable";
            this.InterestRateLable.Size = new System.Drawing.Size(250, 82);
            this.InterestRateLable.TabIndex = 8;
            this.InterestRateLable.Text = "0%";
            this.InterestRateLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Процентная ставка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentSheduleDGV
            // 
            PaymentSheduleDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PaymentSheduleDGV.BackgroundColor = Color.FromArgb(36, 74, 154);
            PaymentSheduleDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentSheduleDGV.Columns.AddRange(new DataGridViewColumn[] { Year, Month, Payment, RemainingPayment });
            PaymentSheduleDGV.Dock = DockStyle.Fill;
            PaymentSheduleDGV.Location = new Point(419, 204);
            PaymentSheduleDGV.Name = "PaymentSheduleDGV";
            PaymentSheduleDGV.RowHeadersWidth = 51;
            PaymentSheduleDGV.RowTemplate.Height = 29;
            PaymentSheduleDGV.Size = new Size(763, 417);
            PaymentSheduleDGV.TabIndex = 9;
            // 
            // Year
            // 
            Year.HeaderText = "Год";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            // 
            // Month
            // 
            this.Month.HeaderText = "Месяц";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Платёж";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            // 
            // RemainingPayment
            // 
            this.RemainingPayment.HeaderText = "Остаток платежа";
            this.RemainingPayment.MinimumWidth = 6;
            this.RemainingPayment.Name = "RemainingPayment";
            // 
            // Mortgage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 705);
            this.Controls.Add(this.PaymentSheduleDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MainTopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mortgage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSE Bank";
            this.MainTopPanel.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbTerm)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbInitialFee)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentSheduleDGV)).EndInit();
            this.ResumeLayout(false);

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
        private Label lTerm;
        private Label label9;
        private Label lPrice;
        private Label lInitialFee;
        private Panel panel1;
        private Panel panel15;
        private Panel panel14;
        private Panel panel13;
        private Label label11;
        private Label label10;
        private Label label1;
        private Label NecessaryIncomeLabel;
        private Label MonthlyPaymentLabel;
        private Label InterestRateLable;
        private DataGridView PaymentSheduleDGV;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Payment;
        private DataGridViewTextBoxColumn RemainingPayment;
    }
}