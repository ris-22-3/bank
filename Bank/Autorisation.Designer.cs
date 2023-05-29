namespace Bank
{
    partial class Autorisation
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
            AutorisationDownPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            AutorisationButton = new Button();
            PasswordField = new TextBox();
            LoginField = new TextBox();
            AutorisationTopPanel = new Panel();
            label1 = new Label();
            AutorisationDownPanel.SuspendLayout();
            AutorisationTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AutorisationDownPanel
            // 
            AutorisationDownPanel.Controls.Add(label3);
            AutorisationDownPanel.Controls.Add(label2);
            AutorisationDownPanel.Controls.Add(AutorisationButton);
            AutorisationDownPanel.Controls.Add(PasswordField);
            AutorisationDownPanel.Controls.Add(LoginField);
            AutorisationDownPanel.Dock = DockStyle.Bottom;
            AutorisationDownPanel.Location = new Point(0, 113);
            AutorisationDownPanel.Margin = new Padding(3, 4, 3, 4);
            AutorisationDownPanel.Name = "AutorisationDownPanel";
            AutorisationDownPanel.Size = new Size(600, 287);
            AutorisationDownPanel.TabIndex = 2;
            AutorisationDownPanel.MouseDown += AutorisationDownPanel_MouseDown;
            AutorisationDownPanel.MouseMove += AutorisationDownPanel_MouseMove;
            // 
            // label3
            // 
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(269, 119);
            label3.Name = "label3";
            label3.Size = new Size(82, 27);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(269, 34);
            label2.Name = "label2";
            label2.Size = new Size(71, 27);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AutorisationButton
            // 
            AutorisationButton.BackColor = Color.FromArgb(16, 45, 105);
            AutorisationButton.Cursor = Cursors.Hand;
            AutorisationButton.Dock = DockStyle.Bottom;
            AutorisationButton.FlatAppearance.BorderColor = Color.Black;
            AutorisationButton.FlatStyle = FlatStyle.Flat;
            AutorisationButton.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AutorisationButton.ForeColor = SystemColors.ButtonFace;
            AutorisationButton.Location = new Point(0, 211);
            AutorisationButton.Margin = new Padding(3, 4, 3, 4);
            AutorisationButton.Name = "AutorisationButton";
            AutorisationButton.Size = new Size(600, 76);
            AutorisationButton.TabIndex = 2;
            AutorisationButton.Text = "Войти";
            AutorisationButton.UseVisualStyleBackColor = false;
            AutorisationButton.Click += AutorisationButton_Click;
            // 
            // PasswordField
            // 
            PasswordField.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordField.Location = new Point(130, 150);
            PasswordField.Margin = new Padding(3, 4, 3, 4);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(340, 45);
            PasswordField.TabIndex = 1;
            PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LoginField.Location = new Point(130, 65);
            LoginField.Margin = new Padding(3, 4, 3, 4);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(340, 45);
            LoginField.TabIndex = 0;
            // 
            // AutorisationTopPanel
            // 
            AutorisationTopPanel.Controls.Add(label1);
            AutorisationTopPanel.Dock = DockStyle.Fill;
            AutorisationTopPanel.Location = new Point(0, 0);
            AutorisationTopPanel.Name = "AutorisationTopPanel";
            AutorisationTopPanel.Size = new Size(600, 113);
            AutorisationTopPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(16, 45, 105);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(600, 113);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Autorisation
            // 
            AcceptButton = AutorisationButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(AutorisationTopPanel);
            Controls.Add(AutorisationDownPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Autorisation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autorisation";
            AutorisationDownPanel.ResumeLayout(false);
            AutorisationDownPanel.PerformLayout();
            AutorisationTopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel AutorisationDownPanel;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button AutorisationButton;
        private Panel AutorisationTopPanel;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}