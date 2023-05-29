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
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodType = new System.Windows.Forms.ComboBox();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxChartType1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodType1 = new System.Windows.Forms.ComboBox();
            this.panelCharts1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 758);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1166, 718);
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
            this.tabControl2.Size = new System.Drawing.Size(1160, 712);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl2_DrawItem);
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Bank.Properties.Resources.лендинг_1_2;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.comboBoxChartType);
            this.tabPage3.Controls.Add(this.comboBoxMonth);
            this.tabPage3.Controls.Add(this.comboBoxPeriodType);
            this.tabPage3.Controls.Add(this.panelCharts);
            this.tabPage3.Location = new System.Drawing.Point(4, 50);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1152, 658);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxChartType
            // 
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
            this.comboBoxMonth.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(221, 48);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(223, 48);
            this.comboBoxMonth.TabIndex = 2;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // comboBoxPeriodType
            // 
            this.comboBoxPeriodType.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPeriodType.FormattingEnabled = true;
            this.comboBoxPeriodType.Location = new System.Drawing.Point(7, 48);
            this.comboBoxPeriodType.Name = "comboBoxPeriodType";
            this.comboBoxPeriodType.Size = new System.Drawing.Size(208, 48);
            this.comboBoxPeriodType.TabIndex = 1;
            this.comboBoxPeriodType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriodType_SelectedIndexChanged);
            // 
            // panelCharts
            // 
            this.panelCharts.BackColor = System.Drawing.Color.White;
            this.panelCharts.Controls.Add(this.Chart);
            this.panelCharts.Location = new System.Drawing.Point(7, 102);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(1091, 539);
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
            this.Chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseMove);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Bank.Properties.Resources.лендинг_1_2;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.comboBoxChartType1);
            this.tabPage4.Controls.Add(this.comboBoxMonth1);
            this.tabPage4.Controls.Add(this.comboBoxPeriodType1);
            this.tabPage4.Controls.Add(this.panelCharts1);
            this.tabPage4.Location = new System.Drawing.Point(4, 50);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1152, 658);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxChartType1
            // 
            this.comboBoxChartType1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxChartType1.FormattingEnabled = true;
            this.comboBoxChartType1.Location = new System.Drawing.Point(452, 48);
            this.comboBoxChartType1.Name = "comboBoxChartType1";
            this.comboBoxChartType1.Size = new System.Drawing.Size(246, 48);
            this.comboBoxChartType1.TabIndex = 3;
            this.comboBoxChartType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType1_SelectedIndexChanged);
            // 
            // comboBoxMonth1
            // 
            this.comboBoxMonth1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMonth1.FormattingEnabled = true;
            this.comboBoxMonth1.Location = new System.Drawing.Point(221, 48);
            this.comboBoxMonth1.Name = "comboBoxMonth1";
            this.comboBoxMonth1.Size = new System.Drawing.Size(223, 48);
            this.comboBoxMonth1.TabIndex = 2;
            this.comboBoxMonth1.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth1_SelectedIndexChanged);
            // 
            // comboBoxPeriodType1
            // 
            this.comboBoxPeriodType1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPeriodType1.FormattingEnabled = true;
            this.comboBoxPeriodType1.Location = new System.Drawing.Point(7, 48);
            this.comboBoxPeriodType1.Name = "comboBoxPeriodType1";
            this.comboBoxPeriodType1.Size = new System.Drawing.Size(203, 48);
            this.comboBoxPeriodType1.TabIndex = 1;
            this.comboBoxPeriodType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriodType1_SelectedIndexChanged);
            // 
            // panelCharts1
            // 
            this.panelCharts1.BackColor = System.Drawing.Color.White;
            this.panelCharts1.Location = new System.Drawing.Point(7, 102);
            this.panelCharts1.Name = "panelCharts1";
            this.panelCharts1.Size = new System.Drawing.Size(1091, 539);
            this.panelCharts1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Bank.Properties.Resources.лендинг_1_2;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1166, 718);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 758);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.tabPage4.ResumeLayout(false);
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
    }
}