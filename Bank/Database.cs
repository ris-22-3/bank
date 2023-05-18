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
        public static string address = "./Data/UserDataBase.csv";
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
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //StreamReader rd = new StreamReader(address, Encoding.GetEncoding(1251));
            //string[] history = new string[0];
            //string[] income = new string[0];
            //string[] costs = new string[0];
            //while (!rd.EndOfStream)
            //{
            //    string str = rd.ReadLine();
            //    string[] onestr = str.Split(new char[] { ';' });
            //    //for (int j = 0; j < history.Length; j++)
            //    //{
            //    //    history[j] = onestr[j+6];
            //    //}
            //    string[] data = ReadFile(address);
            //    for (int i = 1; i < data.Length - 1; i++)
            //    {
            //        string[] ones = data[i].Split(new char[] { ';' });
            //        string[] operations = ReadFile("./Data/" + ones[0].ToString() + ".csv");
            //        income = operations[1].Split(new char[] { ';' }); //сделать срез и убрать название строки 
            //        costs = operations[2].Split(new char[] { ';' });
            //        User time = new User(ones[0], ones[1], ones[2], ones[3], ones[4], ones[5], income, costs);
            //        arr.Add(time);
            //        logins.Add(time.cardNumber);
            //    }
            //    //User time = new User(onestr[0], onestr[1], onestr[2], onestr[3], onestr[4], onestr[5], income, costs);
            //    //arr.Add(time);
            //    //logins.Add(time.cardNumber);
            //}
            string[] data = ReadFile(address);
            for (int i = 1; i < data.Length; i++)
            {
                string[] ones = data[i].Split(new char[] { ';' });
                string[] operations = ReadFile("./Data/" + ones[0].ToString() + ".csv");
                string[] income = operations[1].Split(new char[] { ';' }); //сделать срез и убрать название строки 
                string[] costs = operations[2].Split(new char[] { ';' });
                User time = new User(ones[1], ones[2], ones[3], ones[4], ones[5], ones[6], income, costs);
                arr.Add(time);
                logins.Add(time.cardNumber);
            }
            //User time = new User(onestr[0], onestr[1], onestr[2], onestr[3], onestr[4], onestr[5], income, costs);
            //arr.Add(time);
            //logins.Add(time.cardNumber);
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