using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public struct User
    {
        public string name;
        public string surname;
        public string lastname;
        public string cardNumber;         //пройтись реджексом и преобразовать в нужный формат
        public string password;
        public bool isMortgage;
        public bool isDeposit;
        public CurrencyAccount rub;
        public CurrencyAccount usd;
        public CurrencyAccount tenge;
        public int clientNumber;
        public CurrencyAccount deposit;

        public User(int _clientNumber, string _cardnumber, string _password, string _name, string _surname, string _lastname, CurrencyAccount _rub, CurrencyAccount _usd, CurrencyAccount _tenge, bool _isMortgage, bool _isDeposit, CurrencyAccount _deposit)
        {
            clientNumber = _clientNumber;
            name = _name;
            surname = _surname;
            lastname = _lastname;
            cardNumber = _cardnumber;
            password = _password;
            rub = _rub;
            usd = _usd;
            tenge = _tenge;
            isMortgage = _isMortgage;
            isDeposit = _isDeposit;
            deposit = _deposit;
        }
    }
}