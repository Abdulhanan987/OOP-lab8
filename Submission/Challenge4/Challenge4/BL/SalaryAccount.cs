using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class SalaryAccount : Account
    {
        public SalaryAccount(string title, string number, float balance) : base(title, number, balance)
        {
        }
        public void depositMoney(float amount)
        {
            Balance += amount;
        }
        public bool withdrawMoney(float amount) 
        {
            if(Balance<amount)
            {
                return false;
            }
            Balance -= amount;
            return true;
        }
        public void taxCalculation()
        {
            Balance = Balance - (Balance*0.1f);
        }
    }
}
