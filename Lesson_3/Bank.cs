using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{

    class Bank
    {             
        public class Account
        {
            private string _typeaccount;
            private Guid _number;
            private int _balance;

            public Account(string typeaccount, int balance): this(Guid.Empty, typeaccount , balance) { }
            public Account(string typeaccount) : this(Guid.Empty, typeaccount, 0) { }
            private Account(Guid number, string typeaccount, int balance)
            {

                number = Guid.NewGuid();
                _number = number;
                _typeaccount = typeaccount;
                _balance = balance;
            }     
            public void GetInfoAccount ()
            {
                Console.WriteLine($"Номер вашего счета:{_number} \nТип вашего счета: {_typeaccount} \nБаланс вашего счета: {_balance}");
            }
            public void GetMonney (int balance)
            {                    
                if (_balance > 0 && _balance > balance )
                {
                    _balance = _balance - balance;
                    Console.WriteLine($"На вашем счету {_number} осталось  : {_balance}");
                }
                else
                {
                    Console.WriteLine("На вашем счету недостаточно средств для списания");
                }
            }
            public void SetMonney(int balance)
            {
                _balance = _balance + balance;
                Console.WriteLine($"Ваш счет {_number} пополнился : Остаток на счету: {_balance}");
            }

            public void TransferMonney(Account account, int balance)
            {               
                _balance = _balance - balance;               
                Console.WriteLine($"Вы перевели деньги на счет {_number} : Остаток на счету: {_balance}");
                account.SetMonney(balance);
            }
        }        
    }
}
