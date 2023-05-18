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
        public string balance;
        public string[] income;
        public string[] costs;


        public User(string _cardnumber, string _password, string _name, string _surname, string _lastname, string _balance, string[] _income, string[] _costs)
        {
            name = _name;
            surname = _surname;
            lastname = _lastname;
            cardNumber = _cardnumber;
            password = _password;
            balance = _balance;
            income = _income;
            costs = _costs;
        }
        public void Add(int operation) //добавляем в массив строк и изменяем баланс
        {
            
        }
        public void Cost()
        {

        }
        //public string ToString()
        //{
        //    return this.name + " " + this.surname + " " + this.lastname + " " + this.cardNumber + " " + this.password;
        //}
    }
}