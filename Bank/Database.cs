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
        public static string adress = "UserDataBase.csv";
        public static int Length
        {
            get => File.ReadAllLines(adress).Length;
        }
        public Database()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader rd = new StreamReader(adress, Encoding.GetEncoding(1251));
            while (!rd.EndOfStream)
            {
                string str = rd.ReadLine();
                string[] onestr = str.Split(new char[] { ';' });
                string[] history = new string[onestr.Length - 6];
                for (int j = 0; j < history.Length; j++)
                {
                    history[j] = onestr[j+6];
                }
                User time = new User(onestr[0], onestr[1], onestr[2], onestr[3], onestr[4], onestr[5], history);
                arr.Add(time);
                logins.Add(time.cardNumber);
            }
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