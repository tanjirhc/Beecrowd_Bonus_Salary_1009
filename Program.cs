using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Bonus_Salary_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Salary, Sales, Incentive, Total;
            string name = Console.ReadLine();
            Salary = Convert.ToDouble(Console.ReadLine());
            Sales = Convert.ToDouble(Console.ReadLine());

            Incentive = (Sales * 0.15);
            Total   = Salary + Incentive;
            
            Console.WriteLine("TOTAL = R$ {0}", Total.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
