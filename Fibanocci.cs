using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Fibanocci
    {
        public static void Fib()
        {
            int i = 0;
            int f1 = 1;
            int f2 = 1;
            int fib;
            Console.WriteLine("**************fibanocci Series****************");
            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("fibonacci series is : {0} {1}", f1, f2);
            for(i=1;i<=n-2;i++)
            {
                fib=f1+f2;
                
                Console.Write(" "+fib);

                f1 = f2;
                f2 = fib;
            }
            

        }
    }
}
