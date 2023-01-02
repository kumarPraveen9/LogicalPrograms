using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void check()
        {
            int PerfectNumber=0;
            Console.WriteLine("**************Perfect Number****************");
            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    PerfectNumber+=i;
                }
            }
            if (n == PerfectNumber)
                Console.WriteLine("Hey, number is Perfectnumber");
            else
                Console.WriteLine("Oops! number is Not Perfectnumber");
        }
    }
}
