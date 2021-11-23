using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class TestBank
    {
        public static void TestSystemBank()
        {
            Bank.Account[] accounts = new Bank.Account[]
            {
                new Bank.Account ("Сберегательный") { },
                new Bank.Account ("Накопительный") { },
            };
            accounts[0].GetInfoAccount();
            accounts[1].GetInfoAccount();

            accounts[0].SetMonney(100);
            accounts[1].SetMonney(100);

            accounts[0].GetMonney(150);
            accounts[1].GetMonney(50);

            accounts[0].SetMonney(100);
            accounts[1].SetMonney(50);

            accounts[0].TransferMonney(accounts[1], 100);

            accounts[0].GetInfoAccount();
            accounts[1].GetInfoAccount();
            ;                      
        } 
    }
}
