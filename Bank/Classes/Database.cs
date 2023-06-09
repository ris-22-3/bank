using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace Bank
{
    public class Database
    {
        static string[] months = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
        public static List<User> arr = new List<User>();
        public static List<string> logins = new List<string>();
        public static string address = "../../../Data/UserDataBase.csv";
        public static int Length
        {
            get => File.ReadAllLines(address).Length;
        }
        public static List<String> ReadFile(string address)
        {
            List<string> strs = new List<string>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader rd = new StreamReader(address);
            while (!rd.EndOfStream)
            {
                string str = rd.ReadLine();
                strs.Add(str);
            }
            rd.Close();
            return strs;
        }
        public static int ToInt(string n)
        {
            int nn = 0;
            bool isInt = int.TryParse(n, out nn);
            return nn;
        }
        public static DateTime ToDateTime(string date)
        {
            string[] data = date.Split(' ');
            // 
            int month = 0 + 1;
            for (int i = 0; i < months.Length; i++)
            {
                if (data[1] == months[i])
                {
                    month = i + 1;
                    break;
                }
            }
            DateTime time = new DateTime(ToInt(data[2]), month, ToInt(data[0]));
            //прописать проверку
            return time;
        }
        public static List<Operation> GetOperations(int clientNumber, Currency cur)
        {
            List<string> operationsUser = ReadFile("../../../Data/" + clientNumber.ToString() + "/" + cur + ".csv");
            List<Operation> result = new List<Operation>();
            for (int i = 0; i < operationsUser.Count; i++)
            {
                List<String> values = operationsUser[i].Split(new char[] { ';' }).ToList();
                if (values[0] == "")
                    break;
                DateTime date = ToDateTime(values[8]);
                Operation op = new Operation(decimal.Parse(values[3]), bool.Parse(values[4]), values[6], values[7], date);
                result.Add(op);
            }
            return result;
        }
        public static void GetUser(string[] ones)
        {
            List<string> operationsUser = ReadFile("../../../Data/" + ones[0].ToString() + ".csv");
            CurrencyAccount rub = new CurrencyAccount(ToInt(ones[6]), GetOperations(ToInt(ones[0]), Currency.RUB), Currency.RUB);
            CurrencyAccount usd = new CurrencyAccount(ToInt(ones[10]), GetOperations(ToInt(ones[0]), Currency.USD), Currency.USD);
            CurrencyAccount tenge = new CurrencyAccount(ToInt(ones[11]), GetOperations(ToInt(ones[0]), Currency.TNG), Currency.TNG);
            Objects.user = new User(int.Parse(ones[0]), ones[1], ones[2], ones[3], ones[4], ones[5], rub, usd, tenge, bool.Parse(ones[7]), bool.Parse(ones[8]));
        }
        //отдельные методы для парсинга отдельно юзера и отдельно операций
        public Database()
        {
            List<string> data = ReadFile(address);
            for (int i = 1; i < data.Count; i++)
            {
                string[] ones = data[i].Split(new char[] { ';' });
                if (ones[0] == "")
                    break;
                GetUser(ones);
                arr.Add(Objects.user);
                logins.Add(Objects.user.cardNumber);
            }
        }
        public void Read()
        {
            List<string> data = ReadFile(address);
            for (int i = 1; i < data.Count; i++)
            {
                string[] ones = data[i].Split(new char[] { ';' });
                if (ones[0] == "")
                    break;
                if (Autorisation.clientNumber == int.Parse(ones[0]))
                {
                    Objects.user.usd.isActive = bool.Parse(ones[12]);
                    Objects.user.tenge.isActive = bool.Parse(ones[13]); //Артёму использовать эти свойства на форме
                }
            }
        }

        public static void AddOperation(Operation op, Currency cur)
        {
            string day = "";
            if (op.date.Day < 10)
                day = "0";
            day += op.date.Day.ToString();
            string date = day + " " + months[op.date.Month - 1] + " " + op.date.Year.ToString() + " г.";
            bool isIncome = false;
            if (op.operationType == OperationType.Income)
                isIncome = true;
            string[] operation = { op.sum.ToString(), isIncome.ToString(), op.category, op.type, date};
            StreamWriter rd = new StreamWriter("../../../Data/" + Objects.user.clientNumber.ToString() + "/" + cur + ".csv", true);
            rd.WriteLine(String.Join(";", operation));
            rd.Close();
            RewriteLine(cur);
        }
        public static void RewriteLine(Currency cur)
        {
            int i = 0;
            string tempFile = "UserDataBase" + ".tmp";
            using (StreamReader sr = new StreamReader(address))
            using (StreamWriter sw = new StreamWriter(tempFile, true))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (Objects.user.clientNumber == i)
                    {
                        string[] ones = line.Split(new char[] { ';' });
                        if (CurrencyAccountForm._isCurAccTng == true) //не совсем понимаю, зачем это
                        {
                            ones[13] = CurrencyAccountForm._isCurAccTng.ToString();
                        }
                        if (CurrencyAccountForm._isCurAccUsd == true) //same
                        {
                            ones[12] = CurrencyAccountForm._isCurAccUsd.ToString();
                        }
                        if (cur == Currency.RUB)
                            ones[6] = Objects.user.rub.Balance.ToString();
                        if (cur == Currency.USD)
                            ones[10] = Objects.user.usd.Balance.ToString();
                        if (cur == Currency.TNG)
                            ones[11] = Objects.user.tenge.Balance.ToString();
    
                        line = string.Join(";", ones);
                        sw.WriteLine(line);
                    }
                    else
                        sw.WriteLine(line);
                    i++;
                }
            }
            File.Delete(address);
            File.Move(tempFile, address);
        }
    }
}
