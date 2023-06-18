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
            string expected = "154;12954;23000;3489;false;rub;������;������ ��������;25 ����� 2018 �.";
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
            DateTime test = Database.ToDateTime("12 ����� 2004 �.");
            Assert.AreEqual(test, new DateTime(2004, 3, 12));
        }
        [TestMethod]
        public void TestGetOperations()
        {
            List<Operation> operations = Database.GetOperations(66666);
            Assert.IsTrue(operations.Count == 199);
        }
        [TestMethod]
        public void TestGetUser()
        {
            List<string> strs = Database.ReadFile("../../../Data/TestDataBase.csv");
            User user = Database.GetUser(strs[2].Split(";"));
            Assert.AreEqual(user.cardNumber, 232323);
        }
        [TestMethod]
        public void TestAddOperation()
        {
            Database d = new Database();
            decimal last = Objects.current.Balance;
            Objects.current.history.Add(new Operation(35, true, "rub", "test", "test", DateTime.Now));
            decimal expected = last + 35;
            Assert.AreEqual(expected, Objects.current.Balance);
        }
    }
}