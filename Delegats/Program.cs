using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    public delegate double @delegate(double a, double b);
    internal class Program
    {

        static public double mnojB(double a, double b)
        {
            return (a + b) * b;
        }
        static public double mnojA(double a, double b)
        {
            return (a + b) * a;
        }
        static public double delA(double a, double b)
        {
            return (a + b) / a;
        }
        static public double delB(double a, double b)
        {
            return (a + b) / b;
        }
        static public double Summ(double a, double b)
        {
            return a + b;
        }
        static public void Consul(@delegate a)
        {
            double x, y;
            Console.Write("Введите параметр А = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите параметр B = ");
            y = Convert.ToDouble(Console.ReadLine());
            foreach (@delegate item in a.GetInvocationList())
            {
                Console.WriteLine($"Результат : " + item(x, y));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
          

            @delegate delg2 = delA;
            delg2 += delB;
            
            @delegate delg1 = mnojA;
            delg1 += Summ;
            delg1 += delA;
            delg1 += delB;

            @delegate delg = Summ;
            delg += mnojA;
            delg += mnojB;

            Consul(delg);
            Consul(delg1);
            Consul(delg2);

            //Console.WriteLine("Отработал первый делегат");
            //foreach (@delegate item in delg.GetInvocationList())
            //{
            //    Console.WriteLine($"Результат : "+item(x,y));
            //}
            //Console.WriteLine("\nОтработал второй делегат");
            //foreach (@delegate item in delg1.GetInvocationList())
            //{
            //    Console.WriteLine($"Результат : " + item(x, y));
            //}
            //Console.WriteLine("\nОтработал третий делегат");
            //foreach (@delegate item in delg2.GetInvocationList())
            //{
            //    Console.WriteLine($"Результат : " + item(x, y));
            //}

        }
    }
}
