﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Tests
{
    [TestClass]
    public class Stats
    {
        private List<ChartData> chartData;

        public void Setup()
        {
            // Создание тестовых данных для тестирования
            chartData = new List<ChartData>()
        {
            new ChartData()
            {
                Date = new DateTime(2023, 1, 1),
                Amount = 1000.50m,
                Income = true,
                Currency = "USD",
                Category = "Category 1"
            },
            new ChartData()
            {
                Date = new DateTime(2023, 1, 2),
                Amount = 500.25m,
                Income = false,
                Currency = "EUR",
                Category = "Category 2"
            }
        };
        }
        [TestMethod]
        public void LoadChartData_ReturnsChartDataList()
        {
            // Act
            Objects.user.clientNumber = 4;
            List<ChartData> result = ChartData.LoadChartData();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<ChartData>));
            Assert.AreEqual(199, result.Count);

            // Additional checks for the accuracy of loaded data
            Assert.AreEqual(new DateTime(2022, 7, 3), result[0].Date);
            Assert.AreEqual(3489m, result[0].Amount);
            Assert.AreEqual(false, result[0].Income);
            Assert.AreEqual("rub", result[0].Currency);
            Assert.AreEqual("Супермаркеты", result[0].Category);
        }
        [TestMethod]
        public void AddDataMonthByCategory_UpdatesExpenseData()
        {
            // Arrange
            List<ChartData> chartData = new List<ChartData>()
    {
        new ChartData()
        {
            Date = new DateTime(2023, 1, 1),
            Amount = 1000.50m,
            Income = false,
            Currency = "USD",
            Category = "Category 1"
        }
    };

            Dictionary<string, decimal> expenseData = new Dictionary<string, decimal>();
            bool hasDataForSelectedMonth = false;
            Chart chart = new Chart();
            chart.Series.Add(new Series());

            // Act
            ChartData.AddDataMonthByCategory(ref chartData, "USD", 1, ref chart, ref hasDataForSelectedMonth, ref expenseData);

            // Assert
            Assert.IsTrue(hasDataForSelectedMonth);
            Assert.AreEqual(1, expenseData.Count);
            Assert.AreEqual(1000.50m, expenseData["Category 1"]);
        }
        [TestMethod]
        public void AddDataMonth_UpdatesChartSeries()
        {
            // Arrange
            List<ChartData> chartData = new List<ChartData>()
    {
        new ChartData()
        {
            Date = new DateTime(2023, 1, 1),
            Amount = 1000.50m,
            Income = true,
            Currency = "USD",
            Category = "Category 1"
        }
    };

            bool hasDataForSelectedMonth = false;
            Chart chart = new Chart();
            chart.Series.Add(new Series());
            Color[] columnColors = new Color[] { Color.Red, Color.Blue };

            // Act
            ChartData.AddDataMonth(ref chartData, "USD", 1, ref chart, ref hasDataForSelectedMonth, columnColors);

            // Debug
            Console.WriteLine("Chart Series Count: " + chart.Series.Count);
            Console.WriteLine("Has Data For Selected Month: " + hasDataForSelectedMonth);

            // Assert
            Assert.IsTrue(hasDataForSelectedMonth);
            Assert.AreEqual(1, chart.Series[0].Points.Count);
            Assert.AreEqual("01 January", chart.Series[0].Points[0].AxisLabel);
            Assert.AreEqual(1000.50, chart.Series[0].Points[0].YValues[0]);
            Assert.AreEqual(Color.Red, chart.Series[0].Points[0].Color);
        }
        [TestMethod]
        public void GetMonthsArray_ReturnsArrayWith12Months()
        {
            // Arrange

            // Act
            string[] result = ChartData.GetMonthsArray();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(string[]));
            Assert.AreEqual(12, result.Length);
        }
    }
}
