using System;
using System.Collections.Generic;

namespace Proverochnaya
{
    class Program
    {   
        static void Main(string[] args)
        {
            // В - 10

            // 1
            /*Console.WriteLine("Введите диаметр - целое число");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту - целое число");
            int h = Convert.ToInt32(Console.ReadLine());
            var v = Math.PI * Math.Pow((d / 2), 2) * h;
            Console.WriteLine($"Объём = {v}");*/

            // 2
            /*int r = 2;
            int x, y;
            x = y = 0;
            string k = "";
            List<(double, (double, double))> parts = new List<(double, (double,double))>();
            while (k != "хватит")
            {   

                Console.WriteLine("Введите координату x - челое или дробное число");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату y - челое или дробное число");
                double y1 = Convert.ToDouble(Console.ReadLine());
                double rast = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));
                if (rast <= r)
                {
                    Console.WriteLine("Эта точка лежит на окружности");
                }
                else
                {
                    Console.WriteLine("Эта точка не лежит на окружности");
                }
                parts.Add((rast, (x1, y1)));
                Console.WriteLine("Если вы хотите завершить ввод точек сейчас, наберите слово 'хватит' ");
                k = Console.ReadLine();
            }
            (double, (double, double)) a_min = (0, (0, 0));
            (double, (double, double)) a_max = (0, (0, 0));
            double max = 0;
            double min = Double.MaxValue;
            foreach (var a in parts)
            {
                if (a.Item1 < min)
                {
                    min = a.Item1;
                    a_min = a;
                }
                if (a.Item1 >= max)
                {
                    max = a.Item1;
                    a_max = a;
                }
            }
            Console.WriteLine($"Самая близкая точка к центру - {a_min.Item2.Item1} {a_min.Item2.Item2}");
            if (max <= r)
            {
                Console.WriteLine($"Все точки в окружности");
            }
            else
            {
                Console.WriteLine($"Самая дальня точка от границы окружности - {a_max.Item2.Item1} {a_max.Item2.Item2}");
            }*/

            SystemE systeme = new SystemE();
            Employee employee1 = new Employee() { FIO=" АОАООА АОАООА АОАООА", tel= "54435354345"};
            Employee employee2 = new Employee() { FIO = "sdfsfsf sdfsdf gfhfgh", tel = "45435354534" };
            Employee employee3 = new Employee() { FIO = "asdsd jhhjkhjk wrewrw", tel = "86786969970" };
            Employee employee4 = new Employee() { FIO = "cxxvv jmhjmkhjm vbvbnv", tel = "2342425354" };
            Employee employee5 = new Employee() { FIO = "dsfsfs fgjjghk jkdgdrte", tel = "2534564575686" };
            employee1.systeme = systeme;
            employee2.systeme = systeme;
            employee3.systeme = systeme;
            employee4.systeme = systeme;
            employee5.systeme = systeme;
            employee1.DestroyShovel();
            employee2.DestroyShovel();
            employee2.DestroyShovel();
            systeme.FindDestroyer();
            Console.WriteLine(systeme.FindDestroyer().FIO + " " + systeme.FindDestroyer().tel);
        }
    }
}
