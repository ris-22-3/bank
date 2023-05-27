using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Bank
{
    public class Database
    {
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
            //string[] strs = new string[Length];
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader rd = new StreamReader(address, Encoding.GetEncoding(1251));
            //int i = 0;
            while (!rd.EndOfStream)
            {
                string str = rd.ReadLine();
                strs.Add(str);
            }
            return strs;
        }
        public Database()
        {
            List<string> data = ReadFile(address);
            for (int i = 1; i < data.Count; i++)
            {
                string[] ones = data[i].Split(new char[] { ';' });
                List<string> operationsUser = ReadFile("../../../Data/" + ones[0].ToString() + ".csv");
                CurencyAccounts rub = new CurencyAccounts();
                CurencyAccounts usd = new CurencyAccounts();
                CurencyAccounts tenge = new CurencyAccounts();
                //User user = new User(ones[1], ones[2], ones[3], ones[4], ones[5], ones[6], );
                for (int j = 1; j < operationsUser.Count; j++)
                {
                    List<string> operations = operationsUser[j].Split(new char[] { ';' }).ToList();
                    Operation op = new Operation(decimal.Parse(operations[3]), bool.Parse(operations[4]), operations[5], operations[6], operations[7], DateTime.Parse(operations[8]));
                    if (op.billeType == "$")
                        usd.Add(op);
                    if (op.billeType == "руб")
                        rub.Add(op);
                    else
                        tenge.Add(op);
                }
                rub.Balance = decimal.Parse(ones[6]);
                usd.Balance = decimal.Parse(ones[10]);
                tenge.Balance = decimal.Parse(ones[11]);
                User user = new User(int.Parse(ones[0]), ones[1], ones[2], ones[3], ones[4], ones[5], rub, usd, tenge, bool.Parse(ones[7]), bool.Parse(ones[8]));
                arr.Add(user);
                logins.Add(user.cardNumber);
            }
        }
        public void AddOperation() //запись в файл и добавление в arr
        {

        }
        public User this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Count)
                    return arr[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Length)
                    arr[index] = value;
            }
        }
        
    }
}