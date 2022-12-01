using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float s;

            while (true)
            {
                try
                {
                    Console.Write("s= ");
                     s = float.Parse(Console.ReadLine());
                    if (s == 0)
                    {
                        Console.WriteLine("Число не может равняться нулю!");
                        continue;
                    }
                    else if (s<0)
                    {
                        Console.WriteLine("Число не может быть отрицательным!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }
           
           
            double a = Math.Sqrt (s/6);
             Console.WriteLine("A=" + a);

        }
    }
}
