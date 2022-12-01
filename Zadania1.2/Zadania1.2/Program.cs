using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int num1;
            int num2;
            while (true)
            {
                try
                {
                    Console.WriteLine("a= ");
                    a=int.Parse(Console.ReadLine());
                    if (a > 10 && a <= 100 || a <= -10 && a >= -100)
               {
                  break;
              }
            else {
                   Console.WriteLine("Число должно быть двухзначным!");
                 
                  continue;
              } 
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректные данные!");
                }
              
            }
            int sum = 0;

           
                num1 = a / 10;
                num2 = a % 10;
                sum = num1 + num2;
            
            if (sum % 2 == 0)
            {
                Console.WriteLine("Сумма четная!");
            }
            else
            {
                Console.WriteLine("Сумма нечетная!");
            }
          
        }
    }
}



            