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
        CurencyAccounts rub;
        CurencyAccounts usd;
        CurencyAccounts tenge;
        //public string[] income;
        //public string[] costs;
        public int clientNumber;


        public User(int _clientNumber, string _cardnumber, string _password, string _name, string _surname, string _lastname, CurencyAccounts _rub, CurencyAccounts _usd, CurencyAccounts _tenge, bool _isMortgage, bool _isDeposit)
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