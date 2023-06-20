using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace Bank.Tests
{
    [TestClass]
    public class ATMTests
    {
        [TestMethod]
        public void TestReadFile()
        {
            List<string> strs = Database.ReadFile("../../../Data/66666.csv");
            string expected = "154;12954;23000;3489;false;rub;Другое;" +
                "Выдача Наличных;25 марта 2018 г.";
            Assert.AreEqual(expected, strs[0]);
        }
        [TestMethod]
        public void TestToInt()
        {
            int test = Database.ToInt("5");
            Assert.AreEqual(test, 5);
        }
        [TestMethod]
        public void TestToIntWrong()
        {
            int test = Database.ToInt("gjerk");
            Assert.AreEqual(test, 0);
        }
        [TestMethod]
        public void TestToDatetime()
        {
            DateTime test = Database.ToDateTime("12 марта 2004 г.");
            Assert.AreEqual(test, new DateTime(2004, 3, 12));
        }
        [TestMethod]
        public void TestGetUser()
        {
            List<string> strs = Database.ReadFile("../../../Data/TestDataBase.csv");
            User user = Database.GetUser(strs[1].Split(";"));
            Assert.AreEqual(user.cardNumber, "232323");
        }
        [TestMethod]
        public void TestAddOperation()
        {
            Database d = new Database();
            int last = Objects.current.history.Count;
            Objects.current.history.Add(new Operation(35, true, "rub",
                "test", "test", DateTime.Now));
            Assert.AreEqual(last + 1, Objects.current.history.Count);
        }
    }
}
