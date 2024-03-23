using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentAccount student = new StudentAccount("Student", "12345678Abd", 500000);
           if( !student.checkBalance())
            {
                Console.WriteLine("The balance is too much");
            }
            if(!student.DepositMoney(12000))
            {
                Console.WriteLine("The balance is too much");
            }
            Console.WriteLine("Student");
            Console.WriteLine(student.getTitle());
            Console.WriteLine(student.getBalance());
            Console.WriteLine(student.getNumber());
            SalaryAccount salary = new SalaryAccount("Salary", "122", 10000);
            bool ans =salary.withdrawMoney(8000);
            Console.WriteLine(salary.getTitle());
            salary.taxCalculation();
            if(ans)
            {
                Console.WriteLine(salary.getBalance());
            }
           
            Console.WriteLine(salary.getNumber());
            SavingAccount account = new SavingAccount("Saving", "111", 15000);
            Console.WriteLine(account.getTitle());
            account.profitCalculation();
            Console.WriteLine(account.getBalance());
            Console.WriteLine(account.getNumber());
            Console.ReadKey();



        }
    }
}
