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
        public string cardNumber;         //пройтись режексом и преобразовать в нужный формат
        public string password;
        public string balance;
        public string[] history;

        public User(string _cardnumber, string _password, string _name, string _surname, string _lastname, string _balance, string[] _history)
        {
            this.name = _name;
            this.surname = _surname;
            this.lastname = _lastname;
            this.cardNumber = _cardnumber;
            this.password = _password;
            this.balance = _balance;
            this.history = _history;
        }
        public string ToString()
        {
            return this.name + " " + this.surname + " " + this.lastname + " " + this.cardNumber + " " + this.password;
        }

        // вынести в библиотеку
    }
}