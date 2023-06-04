using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Globalization;
using System.Windows.Markup;

namespace Bank
{
    public partial class StatisticsForm : Form
    {
        private ToolTip chartToolTip = new ToolTip();
        public StatisticsForm()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            tabPage1.Text = "Анализ финансов";
            tabPage2.Text = "Статистика расходов по типам";
            tabPage3.Text = "                                       Расходы                                       ";
            tabPage4.Text = "                                      Зачисления                                    ";

            // Установка DrawMode в OwnerDrawFixed
            tabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;

            // Обработчик события DrawItem для отрисовки кнопки вкладки
            tabControl2.DrawItem += tabControl2_DrawItem;
        }

        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl2.TabPages[e.Index];

            // Определение цвета фона и цвета текста для кнопки вкладки
            Color backColor = Color.Navy; // Цвет фона
            Color foreColor = Color.White; // Цвет текста

            // Отрисовка фона кнопки вкладки
            using (Brush brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Отрисовка текста кнопки вкладки
            using (Brush brush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(tabPage.Text, e.Font, brush, e.Bounds.X + 4, e.Bounds.Y + 4);
            }
        }




        private void ShowExpenseChart()
        {

            // Очистка существующих элементов диаграммы
            panelCharts.Controls.Clear();

            // Получение выбранного типа диаграммы
            SeriesChartType chartType = GetSelectedChartType();

            // Загрузка данных из файла
            List<ChartData> chartData = ChartData.LoadChartData();

            // Получение выбранного типа периода (год или месяц)
            bool isYearSelected = comboBoxPeriodType.SelectedIndex == 0;

            // Создание объекта диаграммы
            Chart chart = new Chart();
            chart.MouseMove += Chart_MouseMove;
            chartToolTip.SetToolTip(chart, " "); // Пустая подсказка по умолчанию
            chartToolTip.ShowAlways = true; // Показывать подсказку всегда
            // Настройка свойств диаграммы
            chart.Size = new Size(940, 460);
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Add(new Series());
            chart.Series[0].BorderWidth = 5;
            chart.Series["Series1"].Name = "Расходы";

            // Настройка свойства IsValueShownAsLabel для типа Pie
            if (chartType == SeriesChartType.Pie)
            {
                chart.Series[0].IsValueShownAsLabel = true;
                chart.Series[0].Label = " ";
            }

            // Настройка свойств осей и меток
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // Массив цветов для столбцов диаграммы
            Color[] columnColors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Aqua, Color.GreenYellow, Color.Lime, Color.Purple, Color.SkyBlue, Color.Tomato, Color.Plum, Color.DeepPink, Color.Indigo, Color.LemonChiffon, Color.Olive, Color.Salmon, Color.SeaGreen, Color.LawnGreen, Color.Maroon, Color.MistyRose, Color.Gainsboro, Color.MediumSeaGreen, Color.PowderBlue, Color.Crimson, Color.Khaki, Color.Moccasin, Color.Orchid, Color.PeachPuff, Color.Peru, Color.Tan, Color.OldLace };

            // Проверка выбранного периода
            if (isYearSelected)
            {
                comboBoxChartType.Location = new Point(221, 48);
                // Получение данных по месяцам за год
                Dictionary<int, decimal> monthData = new Dictionary<int, decimal>();

                // Инициализация данных по месяцам
                for (int i = 1; i <= 12; i++)
                {
                    monthData[i] = 0;
                }

                // Суммирование данных по месяцам
                foreach (ChartData data in chartData)
                {
                    if (!data.Income && data.Currency == "rub")
                    {
                        int month = data.Date.Month;
                        monthData[month] += data.Amount;
                    }
                }

                // Добавление данных в диаграмму
                foreach (KeyValuePair<int, decimal> entry in monthData)
                {
                    int month = entry.Key;
                    decimal amount = entry.Value;

                    DataPoint dataPoint = new DataPoint();
                    dataPoint.AxisLabel = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                    dataPoint.YValues = new double[] {(double) amount };

                    // Задание цвета столбца
                    int colorIndex = month - 1; // Индекс цвета соответствует номеру месяца (1 - январь, 2 - февраль и т.д.)
                    if (colorIndex < columnColors.Length)
                    {
                        dataPoint.Color = columnColors[colorIndex];
                    }

                    chart.Series[0].Points.Add(dataPoint);
                }

                // Добавление легенды с названиями месяцев
                Legend legend = new Legend();
                legend.Docking = Docking.Right;
                chart.Legends.Add(legend);
                foreach (var point in chart.Series[0].Points)
                {
                    int pointIndex = chart.Series[0].Points.IndexOf(point);
                    int month = pointIndex + 1;
                    string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                    chart.Series[0].Points[pointIndex].LegendText = $" {monthName}";
                }
            }
            else
            {
                comboBoxChartType.Location = new Point(452, 48);
                // Получение выбранного месяца
                int selectedMonth = comboBoxMonth.SelectedIndex + 1;

                // Проверка наличия данных для выбранного месяца
                bool hasDataForSelectedMonth = false;

                // Добавление данных в диаграмму
                foreach (ChartData data in chartData)
                {
                    bool isInSelectedMonth = data.Date.Month == selectedMonth;
                    if (!data.Income && data.Currency == "rub" && isInSelectedMonth)
                    {
                        DataPoint dataPoint = new DataPoint();
                        dataPoint.AxisLabel = data.Date.ToString("dd MMMM");
                        dataPoint.YValues = new double[] {(double) data.Amount };

                        // Задание цвета столбца
                        int colorIndex = data.Date.Day - 1; // Индекс цвета соответствует номеру дня в месяце (1 - первый день, 2 - второй день и т.д.)
                        if (colorIndex < columnColors.Length)
                        {
                            dataPoint.Color = columnColors[colorIndex];
                        }

                        chart.Series[0].Points.Add(dataPoint);
                        hasDataForSelectedMonth = true;
                    }
                }

                // Проверка наличия данных для выбранного месяца
                if (!hasDataForSelectedMonth)
                {
                    Label label = new Label();
                    label.Text = "В этом месяце не было расходов";
                    label.AutoSize = true;
                    label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    panelCharts.Controls.Add(label);
                    label.BringToFront();
                    panelCharts.AutoScroll = true;
                }

                // Добавление легенды с датами в формате "дд месяц"
                Legend legend = new Legend();
                legend.Docking = Docking.Right;
                chart.Legends.Add(legend);
                foreach (var point in chart.Series[0].Points)
                {
                    int pointIndex = chart.Series[0].Points.IndexOf(point);
                    DateTime date = DateTime.ParseExact(point.AxisLabel, "dd MMMM", CultureInfo.CurrentCulture);
                    string formattedDate = date.ToString("dd MMMM");
                    chart.Series[0].Points[pointIndex].LegendText = formattedDate;
                }
            }

            // Настройка типа диаграммы
            chart.Series[0].ChartType = chartType;

            // Добавление диаграммы в панель
            panelCharts.Controls.Add(chart);

        }
        private SeriesChartType GetSelectedChartType()
        {
            if (comboBoxChartType.SelectedIndex == 0)
            {
                return SeriesChartType.Column;
            }
            else if (comboBoxChartType.SelectedIndex == 1)
            {
                return SeriesChartType.Pie;
            }
            else if (comboBoxChartType.SelectedIndex == 2)
            {
                return SeriesChartType.Line;
            }
            else
            {
                return SeriesChartType.Column; // По умолчанию столбчатая диаграмма
            }
        }
        private SeriesChartType GetSelectedChartType1()
        {
            if (comboBoxChartType1.SelectedIndex == 0)
            {
                return SeriesChartType.Column;
            }
            else if (comboBoxChartType1.SelectedIndex == 1)
            {
                return SeriesChartType.Pie;
            }
            else if (comboBoxChartType1.SelectedIndex == 2)
            {
                return SeriesChartType.Line;
            }
            else
            {
                return SeriesChartType.Column; // По умолчанию столбчатая диаграмма
            }
        }
        private SeriesChartType GetSelectedChartType2()
        {
            if (comboBoxChartType2.SelectedIndex == 0)
            {
                return SeriesChartType.Column;
            }
            else if (comboBoxChartType2.SelectedIndex == 1)
            {
                return SeriesChartType.Pie;
            }
            else if (comboBoxChartType2.SelectedIndex == 2)
            {
                return SeriesChartType.Line;
            }
            else
            {
                return SeriesChartType.Column; // По умолчанию столбчатая диаграмма
            }
        }


        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var hitTestResult = chart.HitTest(e.X, e.Y);

            if (hitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                var dataPoint = hitTestResult.Series.Points[hitTestResult.PointIndex];
                string monthName = dataPoint.AxisLabel;
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                string capitalizedMonthName = textInfo.ToTitleCase(monthName);

                string tooltipText = dataPoint.YValues[0].ToString() + " руб." + "\n" + capitalizedMonthName;
                chartToolTip.SetToolTip(chart, tooltipText);
            }
            else
            {
                chartToolTip.Hide(chart);
            }
        }

        private void ShowIncomeChart()
        {
            // Очистка существующих элементов диаграммы
            panelCharts1.Controls.Clear();
            comboBoxMonth1.Visible = true;
            // Получение выбранного типа диаграммы
            SeriesChartType chartType = GetSelectedChartType1();

            // Загрузка данных из файла
            List<ChartData> chartData = ChartData.LoadChartData();

            // Получение выбранного типа периода (год или месяц)
            bool isYearSelected = comboBoxPeriodType1.SelectedIndex == 0;

            // Создание объекта диаграммы
            Chart chart1 = new Chart();
            chart1.MouseMove += Chart_MouseMove;
            chartToolTip.SetToolTip(chart1, " "); // Пустая подсказка по умолчанию
            chartToolTip.ShowAlways = true; // Показывать подсказку всегда

            // Настройка свойств диаграммы
            chart1.Size = new Size(940, 460);
            chart1.ChartAreas.Add(new ChartArea());
            chart1.Series.Add(new Series());
            chart1.Series[0].BorderWidth = 5;
            chart1.Series["Series1"].Name = "Зачисления";

            // Настройка свойства IsValueShownAsLabel для типа Pie
            if (chartType == SeriesChartType.Pie)
            {
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].Label = " ";
            }
            // Настройка свойств осей и меток
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // Определение и инициализация переменной columnColors
            Color[] columnColors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Aqua, Color.GreenYellow, Color.Lime, Color.Purple, Color.SkyBlue, Color.Tomato, Color.Plum, Color.DeepPink, Color.Indigo, Color.LemonChiffon, Color.Olive, Color.Salmon, Color.SeaGreen, Color.LawnGreen, Color.Maroon, Color.MistyRose, Color.Gainsboro, Color.MediumSeaGreen, Color.PowderBlue, Color.Crimson, Color.Khaki, Color.Moccasin, Color.Orchid, Color.PeachPuff, Color.Peru, Color.Tan, Color.OldLace };

            // Проверка выбранного периода
            if (isYearSelected)
            {
                comboBoxChartType1.Location = new Point(221, 48);
                // Получение данных по месяцам за год
                Dictionary<int, decimal> monthData = new Dictionary<int, decimal>();

                // Инициализация данных по месяцам
                for (int i = 1; i <= 12; i++)
                {
                    monthData[i] = 0;
                }

                // Суммирование данных по месяцам
                foreach (ChartData data in chartData)
                {
                    if (data.Income && data.Currency == "rub")
                    {
                        int month = data.Date.Month;
                        monthData[month] += data.Amount;
                    }
                }

                // Добавление данных в диаграмму
                foreach (KeyValuePair<int, decimal> entry in monthData)
                {
                    string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(entry.Key);
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.AxisLabel = monthName;
                    dataPoint.YValues = new double[] {(double) entry.Value };

                    // Задание цвета столбца
                    int colorIndex = entry.Key - 1;
                    if (colorIndex < columnColors.Length)
                    {
                        dataPoint.Color = columnColors[colorIndex];
                    }

                    chart1.Series[0].Points.Add(dataPoint);
                }
            }
            else
            {
                comboBoxChartType1.Location = new Point(452, 48);
                // Получение выбранного месяца
                int selectedMonth = comboBoxMonth1.SelectedIndex + 1;

                // Проверка наличия данных для выбранного месяца
                bool hasDataForSelectedMonth = false;

                // Добавление данных в диаграмму
                foreach (ChartData data in chartData)
                {
                    bool isInSelectedMonth = data.Date.Month == selectedMonth;
                    if (data.Income && data.Currency == "rub" && isInSelectedMonth)
                    {
                        DataPoint dataPoint = new DataPoint();
                        dataPoint.AxisLabel = data.Date.ToString("dd MMMM");
                        dataPoint.YValues = new double[] {(double) data.Amount };

                        // Задание цвета столбца
                        int colorIndex = data.Date.Day - 1; // Индекс цвета соответствует номеру дня в месяце (1 - первый день, 2 - второй день и т.д.)
                        if (colorIndex < columnColors.Length)
                        {
                            dataPoint.Color = columnColors[colorIndex];
                        }

                        chart1.Series[0].Points.Add(dataPoint);
                        hasDataForSelectedMonth = true;
                    }
                }

                // Проверка наличия данных для выбранного месяца
                if (!hasDataForSelectedMonth)
                {
                    Label label = new Label();
                    label.Text = "В этом месяце не было зачислений";
                    label.AutoSize = true;
                    label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    panelCharts1.Controls.Add(label);
                    label.BringToFront();
                    panelCharts1.AutoScroll = true;
                }

                // Добавление легенды с датами в формате "дд месяц"
                Legend legend = new Legend();
                legend.Docking = Docking.Right;
                chart1.Legends.Add(legend);
                foreach (var point in chart1.Series[0].Points)
                {
                    int pointIndex = chart1.Series[0].Points.IndexOf(point);
                    DateTime date = DateTime.ParseExact(point.AxisLabel, "dd MMMM", CultureInfo.CurrentCulture);
                    string formattedDate = date.ToString("dd MMMM");
                    chart1.Series[0].Points[pointIndex].LegendText = formattedDate;
                }
            }

            // Настройка типа диаграммы
            chart1.Series[0].ChartType = chartType;

            // Добавление диаграммы в панель
            panelCharts1.Controls.Add(chart1);
        }

        private void comboBoxPeriodType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Проверка выбранного типа периода и отображение или скрытие ComboBox для выбора месяца
            if (comboBoxPeriodType.SelectedIndex == 1) // Месяц
            {
                comboBoxMonth.Visible = true;
            }
            else
            {
                comboBoxMonth.Visible = false;
            }

            // Обновление диаграммы при изменении типа периода
            ShowExpenseChart();
        }

        private void comboBoxMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Обновление диаграммы при изменении выбранного месяца
            ShowExpenseChart();
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обновление диаграммы при изменении выбранного месяца
            ShowExpenseChart();
        }

        private void StatisticsForm_Load_1(object sender, EventArgs e)
        {
            // Добавление элементов в ComboBox с выбором типа периода
            comboBoxPeriodType.Items.AddRange(new string[] { "Год", "Месяц" });
            comboBoxPeriodType.SelectedIndex = 0;

            // Добавление элементов в ComboBox с выбором типа диаграммы
            comboBoxChartType.Items.AddRange(new string[] { "Столбчатая", "Круговая", "Линейная" });
            comboBoxChartType.SelectedIndex = 0;

            // Добавление всех 12 месяцев в ComboBox
            comboBoxMonth.Items.AddRange(ChartData.GetMonthsArray());
            comboBoxMonth.SelectedIndex = 0;

            // Добавление элементов в ComboBox с выбором типа периода
            comboBoxPeriodType1.Items.AddRange(new string[] { "Год", "Месяц" });
            comboBoxPeriodType1.SelectedIndex = 0;

            // Добавление элементов в ComboBox с выбором типа диаграммы
            comboBoxChartType1.Items.AddRange(new string[] { "Столбчатая", "Круговая", "Линейная" });
            comboBoxChartType1.SelectedIndex = 0;

            // Добавление всех 12 месяцев в ComboBox
            comboBoxMonth1.Items.AddRange(ChartData.GetMonthsArray());
            comboBoxMonth1.SelectedIndex = 0; // Устанавливаем индекс января (0 - январь)
                                              // Добавление элементов в ComboBox с выбором типа периода
            comboBoxPeriodType2.Items.AddRange(new string[] { "Год", "Месяц" });
            comboBoxPeriodType2.SelectedIndex = 0;

            // Добавление элементов в ComboBox с выбором типа диаграммы
            comboBoxChartType2.Items.AddRange(new string[] { "Столбчатая", "Круговая", "Линейная" });
            comboBoxChartType2.SelectedIndex = 0;

            // Добавление всех 12 месяцев в ComboBox
            comboBoxMonth2.Items.AddRange(ChartData.GetMonthsArray());
            comboBoxMonth2.SelectedIndex = 0; // Устанавливаем индекс января (0 - январь)
            // Вызов метода ShowChart для отображения диаграммы
            ShowExpenseChart();
        }

        private void tabControl2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Проверяем выбранную вкладку и обновляем графики
            if (tabControl2.SelectedTab == tabPage3)
            {
                ShowExpenseChart();
            }
            else if (tabControl2.SelectedTab == tabPage4)
            {
                ShowIncomeChart();
            }
        }

        private void comboBoxPeriodType1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowIncomeChart();
        }

        private void comboBoxMonth1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Проверка выбранного типа периода и отображение или скрытие ComboBox для выбора месяца
            if (comboBoxPeriodType1.SelectedIndex == 1) // Месяц
            {
                comboBoxMonth1.Visible = true;
            }
            else
            {
                comboBoxMonth1.Visible = false;
            }

            // Обновление диаграммы при изменении типа периода
            ShowIncomeChart();
        }

        private void comboBoxChartType1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowIncomeChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ShowExpenseByCategoryChart()
        {
            // Очистка существующих элементов диаграммы
            panelCharts2.Controls.Clear();
            comboBoxMonth2.Visible = true;

            // Получение выбранного типа диаграммы
            SeriesChartType chartType = GetSelectedChartType2();

            // Загрузка данных из файла
            List<ChartData> chartData = ChartData.LoadChartData();

            // Получение выбранного типа периода (год или месяц)
            bool isYearSelected = comboBoxPeriodType2.SelectedIndex == 0;

            // Создание объекта диаграммы
            Chart chart2 = new Chart();
            chart2.MouseMove += Chart_MouseMove;
            chartToolTip.SetToolTip(chart2, " "); // Пустая подсказка по умолчанию
            chartToolTip.ShowAlways = true; // Показывать подсказку всегда

            // Настройка свойств диаграммы
            chart2.Size = new Size(940, 460);
            chart2.ChartAreas.Add(new ChartArea());
            chart2.Series.Add(new Series());
            chart2.Series[0].BorderWidth = 5;
            chart2.Series["Series1"].Name = "Расходы";

            // Настройка свойства IsValueShownAsLabel для типа Pie
            if (chartType == SeriesChartType.Pie)
            {
                chart2.Series[0].IsValueShownAsLabel = true;
                chart2.Series[0].Label = " ";
            }

            // Настройка свойств осей и меток
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // Определение и инициализация переменной columnColors
            Color[] columnColors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Aqua, Color.GreenYellow, Color.Lime, Color.Purple, Color.SkyBlue, Color.Tomato, Color.Plum, Color.DeepPink, Color.Indigo, Color.LemonChiffon, Color.Olive, Color.Salmon, Color.SeaGreen, Color.LawnGreen, Color.Maroon, Color.MistyRose, Color.Gainsboro, Color.MediumSeaGreen, Color.PowderBlue, Color.Crimson, Color.Khaki, Color.Moccasin, Color.Orchid, Color.PeachPuff, Color.Peru, Color.Tan, Color.OldLace };

            // Проверка выбранного периода
            if (isYearSelected)
            {
                comboBoxChartType2.Location = new Point(221, 48);
                // Получение данных по типам расходов за год
                Dictionary<string, decimal> expenseData = new Dictionary<string, decimal>();

                // Инициализация данных по типам расходов
                foreach (ChartData data in chartData)
                {
                    if (!data.Income && data.Currency == "rub")
                    {
                        if (!expenseData.ContainsKey(data.Category))
                            expenseData[data.Category] = 0;

                        expenseData[data.Category] += data.Amount;
                    }
                }

                // Добавление данных в диаграмму
                int colorIndex = 0;
                foreach (KeyValuePair<string, decimal> entry in expenseData)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.AxisLabel = entry.Key;
                    dataPoint.YValues = new double[] {(double) entry.Value };

                    // Задание цвета столбца
                    dataPoint.Color = columnColors[colorIndex];

                    chart2.Series[0].Points.Add(dataPoint);

                    // Увеличение индекса цвета и проверка на выход за пределы массива columnColors
                    colorIndex++;
                    if (colorIndex >= columnColors.Length)
                    {
                        colorIndex = 0;
                    }
                }
            }
            else
            {
                comboBoxChartType2.Location = new Point(452, 48);
                // Получение выбранного месяца
                int selectedMonth = comboBoxMonth2.SelectedIndex + 1;

                // Проверка наличия данных для выбранного месяца
                bool hasDataForSelectedMonth = false;
                int colorIndex = 0;
                // Добавление данных в диаграмму
                Dictionary<string, decimal> expenseData = new Dictionary<string, decimal>();
                foreach (ChartData data in chartData)
                {
                    bool isInSelectedMonth = data.Date.Month == selectedMonth;
                    if (!data.Income && data.Currency == "rub" && isInSelectedMonth)
                    {
                        if (!expenseData.ContainsKey(data.Category))
                            expenseData[data.Category] = 0;

                        expenseData[data.Category] += data.Amount;

                        hasDataForSelectedMonth = true;
                    }
                }

                // Добавление данных в диаграмму
                foreach (KeyValuePair<string, decimal> entry in expenseData)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.AxisLabel = entry.Key;
                    dataPoint.YValues = new double[] {(double) entry.Value };

                    // Задание цвета столбца
                    dataPoint.Color = columnColors[colorIndex];

                    chart2.Series[0].Points.Add(dataPoint);

                    // Увеличение индекса цвета и проверка на выход за пределы массива columnColors
                    colorIndex++;
                    if (colorIndex >= columnColors.Length)
                    {
                        colorIndex = 0;
                    }
                }

                // Проверка наличия данных для выбранного месяца
                if (!hasDataForSelectedMonth)
                {
                    Label label = new Label();
                    label.Text = "В этом месяце не было расходов";
                    label.AutoSize = true;
                    label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    panelCharts2.Controls.Add(label);
                    label.BringToFront();
                    panelCharts2.AutoScroll = true;
                }
            }

            // Настройка типа диаграммы
            chart2.Series[0].ChartType = chartType;

            // Добавление диаграммы в панель
            panelCharts2.Controls.Add(chart2);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == tabPage2)
            {
                ShowExpenseByCategoryChart();
            }
        }

        private void comboBoxPeriodType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowExpenseByCategoryChart();
        }

        private void comboBoxMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверка выбранного типа периода и отображение или скрытие ComboBox для выбора месяца
            if (comboBoxPeriodType2.SelectedIndex == 1) // Месяц
            {
                comboBoxMonth2.Visible = true;
            }
            else
            {
                comboBoxMonth2.Visible = false;
            }

            // Обновление диаграммы при изменении типа периода
            ShowExpenseByCategoryChart();
        }

        private void comboBoxChartType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowExpenseByCategoryChart();
        }

        private void Back1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
