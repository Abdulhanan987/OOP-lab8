using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Account
    {
        protected string Title;
        protected string Number;
        protected float Balance;
        public Account(string title, string number, float balance)
        {
            Title = title;
            Number = number;
            Balance = balance;
        }
        public void setBalance(float balance)
        {
            this.Balance = balance;
        }
        public void setTitle(string title)
        {
            this.Title = title;
        }
        public string getTitle()
        {
            return this.Title;
        }
        public void setNumber(string number)
        {
            this.Number = number;
        }
        public float getBalance()
        {
            return this.Balance;
        }
        public string getNumber()
        {
            return this.Number;
        }
    }
}
