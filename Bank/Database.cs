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
        public User[] arr;
        public int Length
        {
            get => File.ReadAllLines(adress).Length;
        }
        public string adress = "UserDataBase.csv";
        public Database()
        {
            User[] array = new User[Length];
            StreamReader rd = new StreamReader(adress, Encoding.GetEncoding(1251));
            int i = 0;
            while (!rd.EndOfStream)
            {
                string str = rd.ReadLine();
                string[] onestr = str.Split(new char[] { ';' });
                string[] history = new string[onestr.Length - 6];
                for (int j = 6; j < history.Length - 1; j++)
                {
                    history[j] = onestr[j];
                }
                array[i++] = new User(onestr[0], onestr[1], onestr[2], onestr[3], onestr[4], onestr[5], history);
            }
            this.arr = array;
        }
        //public void Show()
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        public User this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
            }
        }
    }
}