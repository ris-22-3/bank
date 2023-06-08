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
        public CurrencyAccounts rub;
        public CurrencyAccounts usd;
        public CurrencyAccounts tenge;
        public int clientNumber;
        public List<Operation> history = new List<Operation>();
        public bool currencyAccountUsd;
        public bool currencyAccountTng;

        public User(int _clientNumber, string _cardnumber, string _password, string _name, string _surname, string _lastname, CurrencyAccounts _rub, CurrencyAccounts _usd, CurrencyAccounts _tenge, bool _isMortgage, bool _isDeposit,bool _isCurrencyAccountUsd, bool _isCurrencyAccountTng)
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
            currencyAccountUsd = _isCurrencyAccountUsd;
            currencyAccountTng = _isCurrencyAccountTng;
        }
    }
}