namespace Bank
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            header = new Panel();
            lkButton = new Button();
            statisticButton = new Button();
            mainButton = new Button();
            mortgageButton = new Button();
            button5 = new Button();
            panel1 = new Panel();
            balance = new Label();
            button9 = new Button();
            label6 = new Label();
            button3 = new Button();
            FirstAccountBalance = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            button7 = new Button();
            header.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(lkButton);
            header.Controls.Add(statisticButton);
            header.Controls.Add(mainButton);
            header.Controls.Add(mortgageButton);
            header.Controls.Add(button5);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(862, 69);
            header.TabIndex = 0;
            // 
            // lkButton
            // 
            lkButton.AutoSize = true;
            lkButton.BackColor = SystemColors.Control;
            lkButton.FlatAppearance.BorderSize = 0;
            lkButton.FlatStyle = FlatStyle.Flat;
            lkButton.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lkButton.Location = new Point(52, 9);
            lkButton.Margin = new Padding(3, 4, 3, 4);
            lkButton.Name = "lkButton";
            lkButton.Size = new Size(190, 50);
            lkButton.TabIndex = 4;
            lkButton.Text = "Личный кабинет";
            lkButton.UseVisualStyleBackColor = false;
            // 
            // statisticButton
            // 
            statisticButton.AutoSize = true;
            statisticButton.BackColor = SystemColors.Control;
            statisticButton.FlatAppearance.BorderSize = 0;
            statisticButton.FlatStyle = FlatStyle.Flat;
            statisticButton.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            statisticButton.Location = new Point(511, 9);
            statisticButton.Margin = new Padding(0);
            statisticButton.Name = "statisticButton";
            statisticButton.Size = new Size(140, 50);
            statisticButton.TabIndex = 9;
            statisticButton.Text = "Статистика";
            statisticButton.UseVisualStyleBackColor = false;
            // 
            // mainButton
            // 
            mainButton.AutoSize = true;
            mainButton.BackColor = SystemColors.Control;
            mainButton.FlatAppearance.BorderSize = 0;
            mainButton.FlatStyle = FlatStyle.Flat;
            mainButton.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            mainButton.Location = new Point(392, 9);
            mainButton.Margin = new Padding(0);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(107, 50);
            mainButton.TabIndex = 7;
            mainButton.Text = "Главная";
            mainButton.UseVisualStyleBackColor = false;
            // 
            // mortgageButton
            // 
            mortgageButton.AutoSize = true;
            mortgageButton.BackColor = SystemColors.Control;
            mortgageButton.FlatAppearance.BorderSize = 0;
            mortgageButton.FlatStyle = FlatStyle.Flat;
            mortgageButton.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            mortgageButton.Location = new Point(667, 9);
            mortgageButton.Margin = new Padding(0);
            mortgageButton.Name = "mortgageButton";
            mortgageButton.Size = new Size(110, 50);
            mortgageButton.TabIndex = 4;
            mortgageButton.Text = "Ипотека";
            mortgageButton.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(790, 0);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(49, 71);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(balance);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(FirstAccountBalance);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 69);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 512);
            panel1.TabIndex = 1;
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.Location = new Point(123, 104);
            balance.Name = "balance";
            balance.Size = new Size(50, 20);
            balance.TabIndex = 2;
            balance.Text = "label2";
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(10, 54);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(260, 88);
            button9.TabIndex = 10;
            button9.Text = "        Дебетовая карта";
            button9.TextAlign = ContentAlignment.TopCenter;
            button9.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(86, 268);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 9;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(10, 156);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(260, 88);
            button3.TabIndex = 5;
            button3.Text = "      Открыть новый \r\n      продукт";
            button3.UseVisualStyleBackColor = true;
            // 
            // FirstAccountBalance
            // 
            FirstAccountBalance.AutoSize = true;
            FirstAccountBalance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstAccountBalance.Location = new Point(85, 110);
            FirstAccountBalance.Name = "FirstAccountBalance";
            FirstAccountBalance.Size = new Size(0, 25);
            FirstAccountBalance.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(260, 65);
            label1.TabIndex = 0;
            label1.Text = "Счета и карты";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(310, 69);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 181);
            panel2.TabIndex = 2;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(405, 69);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(135, 88);
            button8.TabIndex = 13;
            button8.Text = "Внести наличные";
            button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(135, 69);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(135, 88);
            button6.TabIndex = 12;
            button6.Text = "Покупка с карты";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(270, 69);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(135, 88);
            button4.TabIndex = 11;
            button4.Text = "Снять наличные";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 69);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(135, 88);
            button2.TabIndex = 10;
            button2.Text = "Конвертация";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 0);
            label7.Margin = new Padding(3, 4, 3, 4);
            label7.Name = "label7";
            label7.Size = new Size(492, 65);
            label7.TabIndex = 0;
            label7.Text = "Платежи и переводы";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(button7);
            panel3.Location = new Point(310, 250);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(547, 331);
            panel3.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 90);
            label8.Name = "label8";
            label8.Size = new Size(226, 20);
            label8.TabIndex = 1;
            label8.Text = "Снятие наличных с карты";
            // 
            // button7
            // 
            button7.FlatAppearance.BorderColor = SystemColors.Control;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(0, 0);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(290, 50);
            button7.TabIndex = 0;
            button7.Text = "Последние операции >";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 581);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(header);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Form1";
            header.ResumeLayout(false);
            header.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button lkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button statisticButton;
        private System.Windows.Forms.Button mortgageButton;
        private System.Windows.Forms.Label FirstAccountBalance;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label balance;
    }
}

