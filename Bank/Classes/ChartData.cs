using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bank
{
    public class ChartData
    {
        public decimal BalanceUSD { get; set; }
        public decimal BalanceRUB { get; set; }
        public decimal BalanceKZT { get; set; }
        public decimal Amount { get; set; }
        public bool Income { get; set; }
        public string Currency { get; set; }
        public string AccountType { get; set; }
        public string Category { get; set; }
        public string OperationType { get; set; }
        public DateTime Date { get; set; }
        public static List<ChartData> LoadChartData()
        {
            List<ChartData> chartData = new List<ChartData>();
            string csvFilePath = "../../../../Bank/Data/" + Objects.user.clientNumber.ToString() + ".csv";
            using (var reader = new StreamReader(csvFilePath))
            {
                // Пропускаем заголовок
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    ChartData data = new ChartData
                    {
                        Date = DateTime.Parse(values[8]),
                        Amount = decimal.Parse(values[3]),
                        Income = bool.Parse(values[4]),
                        Currency = values[5],
                        Category = values[6]
                    };

                    chartData.Add(data);
                }
            }

            return chartData;
        }
        public static string[] GetMonthsArray()
        {
            string[] months = new string[12];

            for (int i = 0; i < 12; i++)
            {
                DateTime month = new DateTime(1, i + 1, 1);
                months[i] = month.ToString("MMMM");
            }

            return months;
        }
        public static void AddDataMonthByCategory(ref List<ChartData> chartData, string currencyType, int selectedMonth, ref Chart chart, ref bool hasDataForSelectedMonth, ref Dictionary<string, decimal> expenseData)
        {
            // Добавление данных в диаграмму
            foreach (ChartData data in chartData)
            {
                bool isInSelectedMonth = data.Date.Month == selectedMonth;
                if (!data.Income && data.Currency == currencyType && isInSelectedMonth)
                {
                    if (!expenseData.ContainsKey(data.Category))
                        expenseData[data.Category] = 0;

                    expenseData[data.Category] += data.Amount;

                    hasDataForSelectedMonth = true;
                }
            }
        }
        public static void AddDataMonth(ref List<ChartData> chartData, string currencyType, int selectedMonth, ref Chart chart, ref bool hasDataForSelectedMonth, Color[] columnColors)
        {
            // Добавление данных в диаграмму
            foreach (ChartData data in chartData)
            {
                bool isInSelectedMonth = data.Date.Month == selectedMonth;
                if (!data.Income && data.Currency == currencyType && isInSelectedMonth)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.AxisLabel = data.Date.ToString("dd MMMM");
                    dataPoint.YValues = new double[] { (double)data.Amount };

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
        }
        public static Dictionary<int, decimal> AddData(List<ChartData> chartData, Dictionary<int, decimal> monthData, string currencyType, bool _isIncome, string selectedYear)
        {
            // Суммирование данных по месяцам
            foreach (ChartData data in chartData)
            {
                bool isInSelectedYear = data.Date.Year.ToString() == selectedYear;
                if (_isIncome)
                {
                    if (data.Income && data.Currency == currencyType && isInSelectedYear)
                    {
                        int month = data.Date.Month;
                        monthData[month] += data.Amount;
                    }
                }
                else
                {
                    if (!data.Income && data.Currency == currencyType && isInSelectedYear)
                    {
                        int month = data.Date.Month;
                        monthData[month] += data.Amount;
                    }
                }
            }
            return monthData;
        }
    }

}
