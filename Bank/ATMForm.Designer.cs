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
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            bAccept = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            button4 = new Button();
            button5 = new Button();
            panel4 = new Panel();
            MainTopPanel.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
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
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 201);
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
            panel2.Size = new Size(335, 201);
            panel2.TabIndex = 0;
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
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(6, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 133);
            panel5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(74, 67);
            label6.Name = "label6";
            label6.Size = new Size(201, 23);
            label6.TabIndex = 1;
            label6.Text = "HSE-card 12** **** **** ****";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(110, 26);
            label5.Name = "label5";
            label5.Size = new Size(98, 31);
            label5.TabIndex = 0;
            label5.Text = "4732,56 ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(64, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 60);
            textBox1.TabIndex = 3;
            // 
            // bAccept
            // 
            bAccept.BackColor = Color.FromArgb(16, 45, 105);
            bAccept.BackgroundImageLayout = ImageLayout.None;
            bAccept.FlatAppearance.BorderSize = 0;
            bAccept.FlatStyle = FlatStyle.Flat;
            bAccept.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bAccept.ForeColor = SystemColors.ButtonFace;
            bAccept.Location = new Point(375, 219);
            bAccept.Name = "bAccept";
            bAccept.Size = new Size(163, 66);
            bAccept.TabIndex = 5;
            bAccept.Text = "500 ₽";
            bAccept.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(16, 45, 105);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(580, 219);
            button1.Name = "button1";
            button1.Size = new Size(163, 66);
            button1.TabIndex = 6;
            button1.Text = "1000 ₽";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(16, 45, 105);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(580, 305);
            button2.Name = "button2";
            button2.Size = new Size(163, 66);
            button2.TabIndex = 8;
            button2.Text = "5000 ₽";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(16, 45, 105);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(375, 305);
            button3.Name = "button3";
            button3.Size = new Size(163, 66);
            button3.TabIndex = 7;
            button3.Text = "2000 ₽";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 45, 105);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(335, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 111);
            panel3.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(16, 45, 105);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(335, 487);
            button4.Name = "button4";
            button4.Size = new Size(447, 66);
            button4.TabIndex = 10;
            button4.Text = "Внести наличные";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(16, 45, 105);
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Dock = DockStyle.Bottom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(335, 421);
            button5.Name = "button5";
            button5.Size = new Size(447, 66);
            button5.TabIndex = 11;
            button5.Text = "Снять наличные";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(6, 258);
            panel4.Name = "panel4";
            panel4.Size = new Size(323, 199);
            panel4.TabIndex = 9;
            // 
            // ATMForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(782, 553);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(bAccept);
            Controls.Add(panel1);
            Controls.Add(MainTopPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ATMForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATMForm";
            MainTopPanel.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Label label5;
        private TextBox textBox1;
        private Button bAccept;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel4;
        private Panel panel3;
        private Button button4;
        private Button button5;
    }
}