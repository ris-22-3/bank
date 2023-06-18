using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bank.Tests
{
    [TestClass]
    public class OperationTests
    {
            Database d = new Database();
        [TestMethod]
        public void AddOperation_WritesToCsvFile()
        {
            // Arrange
            Autorisation.clientNumber = 1;
            Objects.user.clientNumber = 1;
            d = new Database();
            decimal value = 30;
            Operation add = new Operation(value, true, "USD", "Другое", "Пополнение", DateTime.Now);
            string expectedCsvLine = "100000;3376;3241;30;True;USD;Другое;Пополнение;18 июня 2023 г.";
            // Act
            d.Read();
            Database.ReadFile(@"C:\Users\Lenovo\source\repos\bank\Bank\Data/UserDataBase.csv");
            Objects.user = Database.arr[1];
            Objects.user.usd.Add(add, true);
            string[] lines = File.ReadAllLines("../../../Data/" + Objects.user.clientNumber.ToString() + ".csv");
            string lastLine = lines[lines.Length - 1];
            //Debug
            Console.WriteLine(expectedCsvLine);
            Console.WriteLine(lastLine);
            // Assert
            Assert.AreEqual(expectedCsvLine, lastLine);
        }
        [TestMethod]
            public void RewriteLine_UpdatesCsvFile()
            {
                // Arrange
                Autorisation.clientNumber = 1;
                Objects.user.clientNumber = 1;
                d = new Database();
                string billetype = "USD";
                string expectedUpdatedLine = "2;232323;qwerty;Екатерина;Петрова;Алексеевна;3376;false;True;file;100000;3241;True;True;1337";
                Objects.user.usd.Balance = 100000;
                // Act
                d.Read();
                Database.ReadFile(@"C:\Users\Lenovo\source\repos\bank\Bank\Data/UserDataBase.csv");
                Objects.user = Database.arr[1];
                Database.RewriteLine(billetype);
                string[] lines = File.ReadAllLines(Database.address);
                string updatedLine = lines[Objects.user.clientNumber];
                // Debug
                Console.WriteLine(expectedUpdatedLine);
                Console.WriteLine(updatedLine);

                // Assert
                Assert.AreEqual(expectedUpdatedLine, updatedLine);
            }




        






    }
}
