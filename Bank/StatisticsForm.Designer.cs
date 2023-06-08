namespace Bank
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.currencyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodType = new System.Windows.Forms.ComboBox();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.currencyTypeComboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxChartType1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodType1 = new System.Windows.Forms.ComboBox();
            this.panelCharts1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.currencyTypeComboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBoxChartType2 = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth2 = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodType2 = new System.Windows.Forms.ComboBox();
            this.panelCharts2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 653);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1168, 607);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Bank.Properties.Resources.лендинг_1_2;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.comboBoxYear);
            this.tabPage3.Controls.Add(this.currencyTypeComboBox);
            this.tabPage3.Controls.Add(this.comboBoxChartType);
            this.tabPage3.Controls.Add(this.comboBoxMonth);
            this.tabPage3.Controls.Add(this.comboBoxPeriodType);
            this.tabPage3.Controls.Add(this.panelCharts);
            this.tabPage3.Location = new System.Drawing.Point(4, 50);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1160, 553);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(970, 0);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(107, 35);
            this.comboBoxYear.TabIndex = 5;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // currencyTypeComboBox
            // 
            this.currencyTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currencyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.currencyTypeComboBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyTypeComboBox.FormattingEnabled = true;
            this.currencyTypeComboBox.Items.AddRange(new object[] {
            "РУБ",
            "USD",
            "ТГ"});
            this.currencyTypeComboBox.Location = new System.Drawing.Point(1083, 0);
            this.currencyTypeComboBox.Name = "currencyTypeComboBox";
            this.currencyTypeComboBox.Size = new System.Drawing.Size(78, 35);
            this.currencyTypeComboBox.TabIndex = 4;
            this.currencyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyTypeComboBox_SelectedIndexChanged);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Location = new System.Drawing.Point(452, 48);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(240, 48);
            this.comboBoxChartType.TabIndex = 3;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(221, 48);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(223, 48);
            this.comboBoxMonth.TabIndex = 2;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged_1);
            // 
            // comboBoxPeriodType
            // 
            this.comboBoxPeriodType.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPeriodType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPeriodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriodType.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPeriodType.FormattingEnabled = true;
            this.comboBoxPeriodType.Location = new System.Drawing.Point(7, 48);
            this.comboBoxPeriodType.Name = "comboBoxPeriodType";
            this.comboBoxPeriodType.Size = new System.Drawing.Size(208, 48);
            this.comboBoxPeriodType.TabIndex = 1;
            this.comboBoxPeriodType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriodType_SelectedIndexChanged_1);
            // 
            // panelCharts
            // 
            this.panelCharts.BackColor = System.Drawing.Color.White;
            this.panelCharts.Controls.Add(this.Chart);
            this.panelCharts.Location = new System.Drawing.Point(7, 102);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(969, 445);
            this.panelCharts.TabIndex = 0;
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(13, 13);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(375, 375);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Bank.Properties.Resources.лендинг_1_2;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.currencyTypeComboBox1);
            this.tabPage4.Controls.Add(this.comboBoxChartType1);
            this.tabPage4.Controls.Add(this.comboBoxMonth1);
            this.tabPage4.Controls.Add(this.comboBoxPeriodType1);
            this.tabPage4.Controls.Add(this.panelCharts1);
            this.tabPage4.Location = new System.Drawing.Point(4, 50);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1160, 553);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // currencyTypeComboBox1
            // 
            this.currencyTypeComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currencyTypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyTypeComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.currencyTypeComboBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyTypeComboBox1.FormattingEnabled = true;
            this.currencyTypeComboBox1.Items.AddRange(new object[] {
            "РУБ",
            "USD",
            "ТГ"});
            this.currencyTypeComboBox1.Location = new System.Drawing.Point(1083, 0);
            this.currencyTypeComboBox1.Name = "currencyTypeComboBox1";
            this.currencyTypeComboBox1.Size = new System.Drawing.Size(78, 35);
            this.currencyTypeComboBox1.TabIndex = 5;
            this.currencyTypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.currencyTypeComboBox1_SelectedIndexChanged);
            // 
            // comboBoxChartType1
            // 
            this.comboBoxChartType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChartType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChartType1.FormattingEnabled = true;
            this.comboBoxChartType1.Location = new System.Drawing.Point(452, 48);
            this.comboBoxChartType1.Name = "comboBoxChartType1";
            this.comboBoxChartType1.Size = new System.Drawing.Size(239, 48);
            this.comboBoxChartType1.TabIndex = 3;
            this.comboBoxChartType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType1_SelectedIndexChanged_1);
            // 
            // comboBoxMonth1
            // 
            this.comboBoxMonth1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMonth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMonth1.FormattingEnabled = true;
            this.comboBoxMonth1.Location = new System.Drawing.Point(221, 48);
            this.comboBoxMonth1.Name = "comboBoxMonth1";
            this.comboBoxMonth1.Size = new System.Drawing.Size(223, 48);
            this.comboBoxMonth1.TabIndex = 2;
            this.comboBoxMonth1.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth1_SelectedIndexChanged_1);
            // 
            // comboBoxPeriodType1
            // 
            this.comboBoxPeriodType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPeriodType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriodType1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPeriodType1.FormattingEnabled = true;
            this.comboBoxPeriodType1.Location = new System.Drawing.Point(7, 48);
            this.comboBoxPeriodType1.Name = "comboBoxPeriodType1";
            this.comboBoxPeriodType1.Size = new System.Drawing.Size(208, 48);
            this.comboBoxPeriodType1.TabIndex = 1;
            this.comboBoxPeriodType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriodType1_SelectedIndexChanged_1);
            // 
            // panelCharts1
            // 
            this.panelCharts1.BackColor = System.Drawing.Color.White;
            this.panelCharts1.Location = new System.Drawing.Point(7, 102);
            this.panelCharts1.Name = "panelCharts1";
            this.panelCharts1.Size = new System.Drawing.Size(969, 445);
            this.panelCharts1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Bank.Properties.Resources.лендинг_1_2;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.currencyTypeComboBox2);
            this.tabPage2.Controls.Add(this.comboBoxChartType2);
            this.tabPage2.Controls.Add(this.comboBoxMonth2);
            this.tabPage2.Controls.Add(this.comboBoxPeriodType2);
            this.tabPage2.Controls.Add(this.panelCharts2);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // currencyTypeComboBox2
            // 
            this.currencyTypeComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currencyTypeComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyTypeComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.currencyTypeComboBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyTypeComboBox2.FormattingEnabled = true;
            this.currencyTypeComboBox2.Items.AddRange(new object[] {
            "РУБ",
            "USD",
            "ТГ"});
            this.currencyTypeComboBox2.Location = new System.Drawing.Point(1096, 0);
            this.currencyTypeComboBox2.Name = "currencyTypeComboBox2";
            this.currencyTypeComboBox2.Size = new System.Drawing.Size(78, 35);
            this.currencyTypeComboBox2.TabIndex = 6;
            this.currencyTypeComboBox2.SelectedIndexChanged += new System.EventHandler(this.currencyTypeComboBox2_SelectedIndexChanged);
            // 
            // comboBoxChartType2
            // 
            this.comboBoxChartType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType2.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChartType2.FormattingEnabled = true;
            this.comboBoxChartType2.Location = new System.Drawing.Point(450, 48);
            this.comboBoxChartType2.Name = "comboBoxChartType2";
            this.comboBoxChartType2.Size = new System.Drawing.Size(240, 48);
            this.comboBoxChartType2.TabIndex = 3;
            this.comboBoxChartType2.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType2_SelectedIndexChanged);
            // 
            // comboBoxMonth2
            // 
            this.comboBoxMonth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth2.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMonth2.FormattingEnabled = true;
            this.comboBoxMonth2.Location = new System.Drawing.Point(221, 48);
            this.comboBoxMonth2.Name = "comboBoxMonth2";
            this.comboBoxMonth2.Size = new System.Drawing.Size(223, 48);
            this.comboBoxMonth2.TabIndex = 2;
            this.comboBoxMonth2.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth2_SelectedIndexChanged);
            // 
            // comboBoxPeriodType2
            // 
            this.comboBoxPeriodType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriodType2.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPeriodType2.FormattingEnabled = true;
            this.comboBoxPeriodType2.Location = new System.Drawing.Point(7, 48);
            this.comboBoxPeriodType2.Name = "comboBoxPeriodType2";
            this.comboBoxPeriodType2.Size = new System.Drawing.Size(208, 48);
            this.comboBoxPeriodType2.TabIndex = 1;
            this.comboBoxPeriodType2.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriodType2_SelectedIndexChanged);
            // 
            // panelCharts2
            // 
            this.panelCharts2.BackColor = System.Drawing.Color.White;
            this.panelCharts2.Location = new System.Drawing.Point(7, 102);
            this.panelCharts2.Name = "panelCharts2";
            this.panelCharts2.Size = new System.Drawing.Size(969, 445);
            this.panelCharts2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(1026, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 91);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 713);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "HSE Bank";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статистика";
            // 
            // StatisticsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 713);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private ComboBox comboBoxChartType;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxPeriodType;
        private Panel panelCharts;
        private TabPage tabPage4;
        private ComboBox comboBoxChartType1;
        private ComboBox comboBoxMonth1;
        private ComboBox comboBoxPeriodType1;
        private Panel panelCharts1;
        private TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private Button button1;
        private ComboBox comboBoxChartType2;
        private ComboBox comboBoxMonth2;
        private ComboBox comboBoxPeriodType2;
        private Panel panelCharts2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox currencyTypeComboBox;
        private ComboBox currencyTypeComboBox1;
        private ComboBox currencyTypeComboBox2;
        private ComboBox comboBoxYear;
    }
}