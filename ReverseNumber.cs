using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void rev()
        {
            int i = 1;
            int r = 0;
            int s = 0;
            int temp = 0;
            Console.WriteLine("\n***************check Reverse number****************\n ");
            Console.WriteLine("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(i<= n)
            {
                r= n % 10; 
                s = s * 10 + r;
                n=n/10;              
            }
            Console.WriteLine("the reverse of given {0} is : {1}", temp, s);
        }
    }
}
