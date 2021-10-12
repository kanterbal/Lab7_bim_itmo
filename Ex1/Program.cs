using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину x 1-го треугольника");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину y 1-го треугольника");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину z 1-го треугольника");
            double z = Convert.ToDouble(Console.ReadLine());
            double max = AreaTriangle(x, y, z);
            Console.WriteLine("Введите длину x 2-го треугольника");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину y 2-го треугольника");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину z 2-го треугольника");
            z = Convert.ToDouble(Console.ReadLine());
            if (max > AreaTriangle(x, y, z))
            {
                Console.WriteLine("Площадь 1-го треугольника больше");
            }
            else
            {
                if (max < AreaTriangle(x, y, z))
                {
                    Console.WriteLine("Площадь 2-го треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площади треугольников равны");
                }
            }
            Console.ReadKey();
        }

        static double AreaTriangle(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return s;
        }
    }
}
