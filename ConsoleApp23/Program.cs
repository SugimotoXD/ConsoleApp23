using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter N:");
            int N = int.Parse(Console.ReadLine());
            Console.Write("enter x:");
            int x = int.Parse(Console.ReadLine());
            
            double J = 0;
            

            for (int i = 0; i < N; i++)
            {
                  J += Math.Pow(-1, i) * (Math.Pow(x, 2 * i + 1) / (2 * i + 1)) ;
            }
            Console.WriteLine(J);
            
            Console.ReadLine();

        }
    }
}
