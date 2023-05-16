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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutorisationTopPanel = new System.Windows.Forms.Label();
            this.AutorisationDownPanel = new System.Windows.Forms.Panel();
            this.AutorisationButton = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.AutorisationDownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AutorisationTopPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 160);
            this.panel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CloseButton.Location = new System.Drawing.Point(556, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 31);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(752, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // AutorisationTopPanel
            // 
            this.AutorisationTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutorisationTopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AutorisationTopPanel.Location = new System.Drawing.Point(0, 0);
            this.AutorisationTopPanel.Name = "AutorisationTopPanel";
            this.AutorisationTopPanel.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.AutorisationTopPanel.Size = new System.Drawing.Size(600, 160);
            this.AutorisationTopPanel.TabIndex = 1;
            this.AutorisationTopPanel.Text = "Авторизация";
            this.AutorisationTopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutorisationTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutorisationTopPanel_MouseDown);
            this.AutorisationTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AutorisationTopPanel_MouseMove);
            // 
            // AutorisationDownPanel
            // 
            this.AutorisationDownPanel.Controls.Add(this.AutorisationButton);
            this.AutorisationDownPanel.Controls.Add(this.PasswordField);
            this.AutorisationDownPanel.Controls.Add(this.LoginField);
            this.AutorisationDownPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutorisationDownPanel.Location = new System.Drawing.Point(0, 160);
            this.AutorisationDownPanel.Name = "AutorisationDownPanel";
            this.AutorisationDownPanel.Size = new System.Drawing.Size(600, 240);
            this.AutorisationDownPanel.TabIndex = 2;
            this.AutorisationDownPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutorisationDownPanel_MouseDown);
            this.AutorisationDownPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AutorisationDownPanel_MouseMove);
            //// 
            // AutorisationButton
            // 
            this.AutorisationButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AutorisationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutorisationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AutorisationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutorisationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AutorisationButton.Location = new System.Drawing.Point(243, 170);
            this.AutorisationButton.Name = "AutorisationButton";
            this.AutorisationButton.Size = new System.Drawing.Size(120, 45);
            this.AutorisationButton.TabIndex = 2;
            this.AutorisationButton.Text = "Войти";
            this.AutorisationButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AutorisationButton.UseVisualStyleBackColor = false;
            this.AutorisationButton.Click += new System.EventHandler(this.AutorisationButton_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PasswordField.Location = new System.Drawing.Point(130, 78);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(340, 45);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginField.Location = new System.Drawing.Point(130, 0);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(340, 60);
            this.LoginField.TabIndex = 0;
            // 
            // Autorisation
            // 
            this.AcceptButton = this.AutorisationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.AutorisationDownPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autorisation";
            this.Text = "Autorisation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AutorisationDownPanel.ResumeLayout(false);
            this.AutorisationDownPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AutorisationTopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AutorisationDownPanel;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button AutorisationButton;
        private System.Windows.Forms.Label CloseButton;
    }
}