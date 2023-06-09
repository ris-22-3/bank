using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Objects
    {
        public static User user;
        //public static CurrencyAccount rub = user.rub;
        //public static CurrencyAccount usd = user.usd;
        //public static CurrencyAccount tng = user.tenge;
        public static CurrencyAccount current = new CurrencyAccount();
    }
}
