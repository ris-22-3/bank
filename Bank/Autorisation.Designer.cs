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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorisation));
            this.AutorisationDownPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutorisationButton = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.AutorisationTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AutorisationDownPanel.SuspendLayout();
            this.AutorisationTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutorisationDownPanel
            // 
            this.AutorisationDownPanel.Controls.Add(this.label3);
            this.AutorisationDownPanel.Controls.Add(this.label2);
            this.AutorisationDownPanel.Controls.Add(this.AutorisationButton);
            this.AutorisationDownPanel.Controls.Add(this.PasswordField);
            this.AutorisationDownPanel.Controls.Add(this.LoginField);
            this.AutorisationDownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AutorisationDownPanel.Location = new System.Drawing.Point(0, 113);
            this.AutorisationDownPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutorisationDownPanel.Name = "AutorisationDownPanel";
            this.AutorisationDownPanel.Size = new System.Drawing.Size(600, 287);
            this.AutorisationDownPanel.TabIndex = 2;
            this.AutorisationDownPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutorisationDownPanel_MouseDown_1);
            this.AutorisationDownPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AutorisationDownPanel_MouseMove_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(264, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(264, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutorisationButton
            // 
            this.AutorisationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.AutorisationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutorisationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AutorisationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AutorisationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutorisationButton.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutorisationButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AutorisationButton.Location = new System.Drawing.Point(0, 211);
            this.AutorisationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutorisationButton.Name = "AutorisationButton";
            this.AutorisationButton.Size = new System.Drawing.Size(600, 76);
            this.AutorisationButton.TabIndex = 2;
            this.AutorisationButton.Text = "Войти";
            this.AutorisationButton.UseVisualStyleBackColor = false;
            this.AutorisationButton.Click += new System.EventHandler(this.AutorisationButton_Click_1);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordField.Location = new System.Drawing.Point(125, 132);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(340, 45);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginField.Location = new System.Drawing.Point(125, 47);
            this.LoginField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(340, 45);
            this.LoginField.TabIndex = 0;
            // 
            // AutorisationTopPanel
            // 
            this.AutorisationTopPanel.Controls.Add(this.label1);
            this.AutorisationTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutorisationTopPanel.Location = new System.Drawing.Point(0, 0);
            this.AutorisationTopPanel.Name = "AutorisationTopPanel";
            this.AutorisationTopPanel.Size = new System.Drawing.Size(600, 113);
            this.AutorisationTopPanel.TabIndex = 3;
            this.AutorisationTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutorisationTopPanel_MouseDown_1);
            this.AutorisationTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AutorisationTopPanel_MouseMove_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Autorisation
            // 
            this.AcceptButton = this.AutorisationButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.AutorisationTopPanel);
            this.Controls.Add(this.AutorisationDownPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorisation";
            this.AutorisationDownPanel.ResumeLayout(false);
            this.AutorisationDownPanel.PerformLayout();
            this.AutorisationTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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