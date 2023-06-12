namespace Bank
{
    partial class Transfers
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
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iHaveComboBox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblWatermark = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWatermark1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iWillHaveComboBox = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.transferButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 58);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Перевод";
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 58);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hse Bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.iHaveComboBox);
            this.panel2.Location = new System.Drawing.Point(9, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 48);
            this.panel2.TabIndex = 4;
            // 
            // iHaveComboBox
            // 
            this.iHaveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iHaveComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iHaveComboBox.FormattingEnabled = true;
            this.iHaveComboBox.Location = new System.Drawing.Point(3, 3);
            this.iHaveComboBox.Name = "iHaveComboBox";
            this.iHaveComboBox.Size = new System.Drawing.Size(120, 35);
            this.iHaveComboBox.TabIndex = 0;
            this.iHaveComboBox.SelectedIndexChanged += new System.EventHandler(this.iHaveComboBox_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblWatermark);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(12, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 85);
            this.panel4.TabIndex = 6;
            // 
            // lblWatermark
            // 
            this.lblWatermark.AutoSize = true;
            this.lblWatermark.BackColor = System.Drawing.Color.White;
            this.lblWatermark.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWatermark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWatermark.Location = new System.Drawing.Point(15, 15);
            this.lblWatermark.Name = "lblWatermark";
            this.lblWatermark.Size = new System.Drawing.Size(33, 37);
            this.lblWatermark.TabIndex = 9;
            this.lblWatermark.Text = "g";
            this.lblWatermark.Click += new System.EventHandler(this.lblWatermark_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(596, 85);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblWatermark1);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Location = new System.Drawing.Point(12, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(596, 83);
            this.panel5.TabIndex = 7;
            // 
            // lblWatermark1
            // 
            this.lblWatermark1.AutoSize = true;
            this.lblWatermark1.BackColor = System.Drawing.SystemColors.Control;
            this.lblWatermark1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWatermark1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWatermark1.Location = new System.Drawing.Point(15, 12);
            this.lblWatermark1.Name = "lblWatermark1";
            this.lblWatermark1.Size = new System.Drawing.Size(33, 37);
            this.lblWatermark1.TabIndex = 10;
            this.lblWatermark1.Text = "g";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(596, 83);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.iWillHaveComboBox);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(9, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 50);
            this.panel3.TabIndex = 8;
            // 
            // iWillHaveComboBox
            // 
            this.iWillHaveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iWillHaveComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iWillHaveComboBox.FormattingEnabled = true;
            this.iWillHaveComboBox.Location = new System.Drawing.Point(3, 3);
            this.iWillHaveComboBox.Name = "iWillHaveComboBox";
            this.iWillHaveComboBox.Size = new System.Drawing.Size(120, 35);
            this.iWillHaveComboBox.TabIndex = 1;
            this.iWillHaveComboBox.SelectedIndexChanged += new System.EventHandler(this.iWillHaveComboBox_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.transferButton);
            this.panel6.Location = new System.Drawing.Point(475, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(121, 44);
            this.panel6.TabIndex = 11;
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.transferButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferButton.ForeColor = System.Drawing.SystemColors.Control;
            this.transferButton.Location = new System.Drawing.Point(0, 0);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(119, 42);
            this.transferButton.TabIndex = 2;
            this.transferButton.Text = "Перевести";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // Transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 378);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transfers";
            this.Text = "Transfers";
            this.Load += new System.EventHandler(this.Transfers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button backButton;
        private Label label1;
        private Panel panel2;
        private ComboBox iHaveComboBox;
        private Panel panel4;
        private TextBox textBox1;
        private Panel panel5;
        private TextBox textBox2;
        private Panel panel3;
        private Button transferButton;
        private ComboBox iWillHaveComboBox;
        private Label lblWatermark;
        private Label lblWatermark1;
        private Panel panel6;
    }
}