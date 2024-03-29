﻿using Microsoft.VisualBasic.ApplicationServices;
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
        public static string address = "./Data/UserDataBase.csv";
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
            return time;
        }

        public static List<Operation> GetOperations(int clientNumber)
        {
            List<string> operationsUser = ReadFile("./Data/" + clientNumber.ToString() + ".csv");
            List<Operation> result = new List<Operation>();
            for (int i = 1; i < operationsUser.Count; i++)
            {
                List<String> values = operationsUser[i].Split(new char[] { ';' }).ToList();
                if (values[0] == "")
                    break;
                DateTime date = ToDateTime(values[8]);
                Operation op = new Operation(decimal.Parse(values[3]), bool.Parse(values[4]), values[5], values[6], values[7], date);
                result.Add(op);
            }
            return result;
        }

        public static User GetUser(string[] ones)
        {
            List<string> operationsUser = ReadFile("./Data/" + ones[0].ToString() + ".csv");
            List<Operation> operations = GetOperations(ToInt(ones[0]));
            CurrencyAccount rub = new CurrencyAccount(ToInt(ones[6]), 
                operations.Where(x => x.billetype == "rub").ToList(), Currency.RUB);
            CurrencyAccount usd = new CurrencyAccount(ToInt(ones[10]), 
                operations.Where(x => x.billetype == "USD").ToList(), Currency.USD);
            CurrencyAccount tenge = new CurrencyAccount(ToInt(ones[11]), 
                operations.Where(x => x.billetype == "tg").ToList(), Currency.TNG);
            CurrencyAccount deposit = new CurrencyAccount(ToInt(ones[14]), Currency.DEPOSIT);
            rub.isActive = rub.history.Count > 0;
            usd.isActive = usd.history.Count > 0;
            tenge.isActive = tenge.history.Count > 0;
            deposit.isActive = deposit.history.Count > 0;
            User user = new User(int.Parse(ones[0]), ones[1], ones[2], ones[3], ones[4], ones[5], rub, usd, tenge, 
                bool.Parse(ones[7]), bool.Parse(ones[8]), deposit);
            return user;
        }

        public Database()
        {
            List<string> data = ReadFile(address);
            for (int i = 1; i < data.Count; i++)
            {
                string[] ones = data[i].Split(new char[] { ';' });
                if (ones[0] == "")
                    break;
                User user = GetUser(ones);
                arr.Add(user);
                logins.Add(user.cardNumber);
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
                    Objects.user.tenge.isActive = bool.Parse(ones[13]); 
                }
            }
        }

        public static void AddOperation(Operation op)
        {
            string day = "";
            if (op.date.Day < 10)
                day = "0";
            day += op.date.Day.ToString();
            string date = day + " " + months[op.date.Month - 1] + " " + op.date.Year.ToString() + " г.";
            bool isIncome = false;
            if (op.operationType == OperationType.Income)
                isIncome = true;
            string[] operation = { 
                Objects.user.usd.Balance.ToString(), Objects.user.rub.Balance.ToString(), 
                Objects.user.tenge.Balance.ToString(), op.sum.ToString(), isIncome.ToString(), 
                op.billetype.ToString(), op.category, op.type, date 
            };
            StreamWriter rd = new StreamWriter("./Data/" + Objects.user.clientNumber.ToString() + ".csv", true);
            rd.WriteLine(String.Join(";", operation));
            rd.Close();
            RewriteLine(op.billetype);
        }
        public static void RewriteLine(string billetype)
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
                        if (CurrencyAccountForm._isCurAccTng == true)
                        {
                            ones[13] = CurrencyAccountForm._isCurAccTng.ToString();
                        }
                        if (CurrencyAccountForm._isCurAccUsd == true)
                        {
                            ones[12] = CurrencyAccountForm._isCurAccUsd.ToString();
                        }
                        if (Objects.user.isDeposit == true)
                        {
                            ones[8] = Objects.user.isDeposit.ToString();
                        }
                        if (billetype == "rub")
                            ones[6] = Objects.user.rub.Balance.ToString();
                        if (billetype == "USD")
                            ones[10] = Objects.user.usd.Balance.ToString();
                        if (billetype == "tg")
                            ones[11] = Objects.user.tenge.Balance.ToString();
                        if (billetype == "deposit")
                            ones[14] = Objects.user.deposit.Balance.ToString();
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
