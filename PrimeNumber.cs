using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void Primech()
        {
            int i = 2;
            int isPrime = 1;
            Console.WriteLine("\n***************check Prime number****************\n ");
            Console.WriteLine("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = 0;
                }
            }
            if (isPrime == 1)
                Console.WriteLine("the number is prime!!");
            else
                Console.WriteLine("Oops,the number is not prime");

        }
    }
}

