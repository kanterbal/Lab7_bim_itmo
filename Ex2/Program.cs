using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба - ");
            double a = Convert.ToDouble(Console.ReadLine());
            AreaCube(a);
            VolumeCube(a);
            Console.ReadKey();
        }
        static void AreaCube(double a)
        {
            Console.WriteLine("Площадь поверхности куба = {0}",6 * Math.Pow(a, 2));
        }
        static void VolumeCube(double a)
        {
            Console.WriteLine("Объем куба = {0}",Math.Pow(a, 3));
        }
    }
}
