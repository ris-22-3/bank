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
            lHSE = new Label();
            panel11 = new Panel();
            label7 = new Label();
            panel10 = new Panel();
            BackButton = new Button();
            MainTopPanel.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
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
            // ATMForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(782, 553);
            Controls.Add(MainTopPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ATMForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATMForm";
            MainTopPanel.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
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
    }
}