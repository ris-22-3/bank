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
        public string[] ReadFile(string address)
        {
            string[] strs = new string[Length];
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader rd = new StreamReader(address, Encoding.GetEncoding(1251));
            int i = 0;
            while (!rd.EndOfStream)
            {
                string str = rd.ReadLine();
                strs[i++] = str;
            }
            return strs;
        }
        public Database()
        {
            string[] data = ReadFile(address);
            for (int i = 1; i < data.Length; i++)
            {
                string[] ones = data[i].Split(new char[] { ';' });
                string[] operations = ReadFile("../../../Data/" + ones[0].ToString() + ".csv");
                string[] income = operations[1].Split(new char[] { ';' }); //сделать срез (убрать название строки) 
                string[] costs = operations[2].Split(new char[] { ';' });
                User time = new User(ones[1], ones[2], ones[3], ones[4], ones[5], ones[6], income, costs);
                arr.Add(time);
                logins.Add(time.cardNumber);
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