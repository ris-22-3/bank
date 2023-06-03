using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ChartData
    {
        public double BalanceUSD { get; set; }
        public double BalanceRUB { get; set; }
        public double BalanceKZT { get; set; }
        public double Amount { get; set; }
        public bool Income { get; set; }
        public string Currency { get; set; }
        public string AccountType { get; set; }
        public string Category { get; set; }
        public string OperationType { get; set; }
        public DateTime Date { get; set; }
        public static List<ChartData> LoadChartData()
        {
            List<ChartData> chartData = new List<ChartData>();
            string csvFilePath = "../../../Data/" + Objects.user.clientNumber.ToString() + ".csv";
            using (var reader = new StreamReader(csvFilePath, Encoding.GetEncoding(1251)))
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
                        Amount = double.Parse(values[3]),
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
    }

}
