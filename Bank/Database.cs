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
        static string[] months = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "ноября", "декабря" };
        public static List<User> arr = new List<User>();
        public static List<string> logins = new List<string>();
        public static string address = "../../../Data/UserDataBase.csv";
        public static int Length
        {
            get => File.ReadAllLines(address).Length;
        }
        public List<String> ReadFile(string address)
        {
            List<string> strs = new List<string>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader rd = new StreamReader(address, Encoding.GetEncoding(1251));
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
        public Database()
        {
            List<string> data = ReadFile(address);
            for (int i = 1; i < data.Count; i++)
            {
                string[] ones = data[i].Split(new char[] { ';' });
                if (ones[0] == "")
                    break;
                List<string> operationsUser = ReadFile("../../../Data/" + ones[0].ToString() + ".csv");
                CurencyAccounts rub = new CurencyAccounts();
                CurencyAccounts usd = new CurencyAccounts();
                CurencyAccounts tenge = new CurencyAccounts();
                Objects.user = new User(int.Parse(ones[0]), ones[1], ones[2], ones[3], ones[4], ones[5], rub, usd, tenge, bool.Parse(ones[7]), bool.Parse(ones[8]));
                for (int j = 1; j < operationsUser.Count; j++)
                {
                    List<string> operations = operationsUser[j].Split(new char[] { ';' }).ToList();
                    if (operations[0] == "")
                        break;
                    DateTime date = ToDateTime(operations[8]);
                    Operation op = new Operation(decimal.Parse(operations[3]), bool.Parse(operations[4]), operations[5], operations[6], operations[7], date);
                    if (op.billeType == "USD")
                        usd.Add(op);
                    if (op.billeType == "rub")
                        rub.Add(op);
                    else
                        tenge.Add(op);
                }
                rub.Balance = decimal.Parse(ones[6]);
                usd.Balance = decimal.Parse(ones[10]);
                tenge.Balance = decimal.Parse(ones[11]);
                arr.Add(Objects.user);
                logins.Add(Objects.user.cardNumber);
            }
        }
        public static void AddOperation(Operation op)
        {
            string[] operation = { Objects.user.usd.Balance.ToString(), Objects.user.rub.Balance.ToString(), Objects.user.tenge.Balance.ToString(), op.sum.ToString(), op.isIncome.ToString(), op.billeType.ToString(), op.category, op.type, op.date.Day.ToString() + " "+ months[op.date.Month-1] + " " + op.date.Year.ToString() + " г."}; 
            StreamWriter rd = new StreamWriter("../../../Data/" + Objects.user.clientNumber.ToString() + ".csv", true, Encoding.GetEncoding(1251));
            rd.WriteLine(String.Join(";", operation));
            rd.Close();
            RewriteLine(op.billeType);

            //rd = new StreamWriter("../../../Data/" + address + ".csv", true, Encoding.GetEncoding(1251));
            //rd.Write(String.Join(";", operation));
            //rd.WriteLine(String.Join(";", operation));
            //rd.Close();
            // изменить в файле UserDataBase баланс при добавлении операции
            //обернуть в try catch?

            
        }
        private static void RewriteLine(string billeType)
        {
            int i = 0;
            string tempFile = "UserDataBase" + ".tmp";
            using (StreamReader sr = new StreamReader(address, Encoding.GetEncoding(1251)))
            using (StreamWriter sw = new StreamWriter(tempFile, true, Encoding.GetEncoding(1251)))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (Objects.user.clientNumber == i)
                    {
                        string[] ones = line.Split(new char[] { ';' });
                        if (billeType == "rub")
                            ones[6] = Objects.user.rub.Balance.ToString();
                        if (billeType == "USD")
                            ones[10] = Objects.user.usd.Balance.ToString();
                        if (billeType == "tg")
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