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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            comboBoxChartType = new ComboBox();
            comboBoxMonth = new ComboBox();
            comboBoxPeriodType = new ComboBox();
            panelCharts = new Panel();
            Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage4 = new TabPage();
            comboBoxChartType1 = new ComboBox();
            comboBoxMonth1 = new ComboBox();
            comboBoxPeriodType1 = new ComboBox();
            panelCharts1 = new Panel();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Chart).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1174, 758);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Location = new Point(4, 36);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1166, 718);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1160, 712);
            tabControl2.TabIndex = 0;
            tabControl2.DrawItem += tabControl2_DrawItem;
            tabControl2.SelectedIndexChanged += tabControl2_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.лендинг_1_2;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(comboBoxChartType);
            tabPage3.Controls.Add(comboBoxMonth);
            tabPage3.Controls.Add(comboBoxPeriodType);
            tabPage3.Controls.Add(panelCharts);
            tabPage3.Location = new Point(4, 50);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1152, 658);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxChartType.FormattingEnabled = true;
            comboBoxChartType.Location = new Point(452, 48);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(240, 48);
            comboBoxChartType.TabIndex = 3;
            comboBoxChartType.SelectedIndexChanged += comboBoxChartType_SelectedIndexChanged;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(221, 48);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(223, 48);
            comboBoxMonth.TabIndex = 2;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // comboBoxPeriodType
            // 
            comboBoxPeriodType.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPeriodType.FormattingEnabled = true;
            comboBoxPeriodType.Location = new Point(7, 48);
            comboBoxPeriodType.Name = "comboBoxPeriodType";
            comboBoxPeriodType.Size = new Size(208, 48);
            comboBoxPeriodType.TabIndex = 1;
            comboBoxPeriodType.SelectedIndexChanged += comboBoxPeriodType_SelectedIndexChanged;
            // 
            // panelCharts
            // 
            panelCharts.BackColor = Color.White;
            panelCharts.Controls.Add(Chart);
            panelCharts.Location = new Point(7, 102);
            panelCharts.Name = "panelCharts";
            panelCharts.Size = new Size(1091, 539);
            panelCharts.TabIndex = 0;
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            Chart.Legends.Add(legend1);
            Chart.Location = new Point(13, 13);
            Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            Chart.Series.Add(series1);
            Chart.Size = new Size(375, 375);
            Chart.TabIndex = 0;
            Chart.Text = "chart1";
            Chart.MouseMove += Chart_MouseMove;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources.лендинг_1_2;
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(comboBoxChartType1);
            tabPage4.Controls.Add(comboBoxMonth1);
            tabPage4.Controls.Add(comboBoxPeriodType1);
            tabPage4.Controls.Add(panelCharts1);
            tabPage4.Location = new Point(4, 50);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1152, 658);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxChartType1
            // 
            comboBoxChartType1.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxChartType1.FormattingEnabled = true;
            comboBoxChartType1.Location = new Point(452, 48);
            comboBoxChartType1.Name = "comboBoxChartType1";
            comboBoxChartType1.Size = new Size(246, 48);
            comboBoxChartType1.TabIndex = 3;
            comboBoxChartType1.SelectedIndexChanged += comboBoxChartType1_SelectedIndexChanged;
            // 
            // comboBoxMonth1
            // 
            comboBoxMonth1.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMonth1.FormattingEnabled = true;
            comboBoxMonth1.Location = new Point(221, 48);
            comboBoxMonth1.Name = "comboBoxMonth1";
            comboBoxMonth1.Size = new Size(223, 48);
            comboBoxMonth1.TabIndex = 2;
            comboBoxMonth1.SelectedIndexChanged += comboBoxMonth1_SelectedIndexChanged;
            // 
            // comboBoxPeriodType1
            // 
            comboBoxPeriodType1.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxPeriodType1.FormattingEnabled = true;
            comboBoxPeriodType1.Location = new Point(7, 48);
            comboBoxPeriodType1.Name = "comboBoxPeriodType1";
            comboBoxPeriodType1.Size = new Size(203, 48);
            comboBoxPeriodType1.TabIndex = 1;
            comboBoxPeriodType1.SelectedIndexChanged += comboBoxPeriodType1_SelectedIndexChanged;
            // 
            // panelCharts1
            // 
            panelCharts1.BackColor = Color.White;
            panelCharts1.Location = new Point(7, 102);
            panelCharts1.Name = "panelCharts1";
            panelCharts1.Size = new Size(1091, 539);
            panelCharts1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.лендинг_1_2;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Location = new Point(4, 36);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1166, 718);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1174, 758);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatisticsForm";
            Load += StatisticsForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Chart).EndInit();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
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