using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class SortByData : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Operation s1 = x as Operation;
            Operation s2 = y as Operation;
            if (s1 == null || s2 == null)
                return 0;
            if (s1.date == s2.date)
                return 0;
            if (s1.date > s2.date)
                return 1;
            return -1;
        }
    }
}
