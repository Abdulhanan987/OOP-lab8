using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class StudentAccount : Account
    {
        public StudentAccount(string title, string number, float balance) : base(title, number, balance)
        {
        }

        
        public bool checkBalance()
        {
            if(Balance>500000)
            {
                return false;
            }
            return true;
        }
        public bool DepositMoney(float money)
        {
            if(Balance +money>500000)
            {
                return false;
            }
            return true;
        }
        public bool WithdrawMoney(float amount) 
        {
            if(Balance<amount) 
            {
                return false;
            }
            Balance -= amount;
            return true;
        }
    }

}
