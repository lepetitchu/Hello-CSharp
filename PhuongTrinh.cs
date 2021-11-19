//Code by: Chu Quang Thao - 2021
using System;
using System.Collections.Generic;
using System.Text;

namespace TongHop_1
{
    class PhuongTrinh
    {
        //Giai phuong trinh ax + b = 0
        public static void PTBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh co Vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh Vo nghiem");
            }
            else
                Console.WriteLine("Phuong trinh co 1 nghiem x = {0}", -b/a);
        }

        //Giai phuong trinh ax² + bx + c = 0
        public static void PTBac2(double a, double b, double c)
        {
            if (a == 0)
            {
                //Giai phuong trinh bac 1
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co Vo so nghiem");
                    else
                        Console.WriteLine("Phuong trinh Vo nghiem");
                }
                else
                    Console.WriteLine("Phuong trinh co 1 nghiem x = {0}", -c / b);
            }
            else
            {
                double delta = b * b - 4d * a * c;
                if (delta < 0)
                    Console.WriteLine("Phuong trinh Vo nghiem");
                else if (delta ==0)
                    Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = {0}", -b/(a*2));
                else
                    Console.WriteLine("Phuong trinh co 2 nghiem: x1 = {0}; x2 = {1}", (-b + Math.Sqrt(delta)) / (a*2), (-b - Math.Sqrt(delta)) / (a * 2));
            }
        }

        //Giai he phuong trinh ax + by = c, dx + ey = f
        public static void HePT_2An(double a, double b, double c, double d, double e, double f)
        {
            double x = (c * e - b * f) / (a * e - b * d);
            double y = (a * f - c * d) / (a * e - b * d);
            Console.WriteLine($"x = {x}, y = {y}");
        }
		
		public static void GiaiPTBac3(double a, double b, double c, double d)
        {
            double delta = b * b - 3d * a * c;
            double k = (9d * a * b * c - 2d * b * b * b - 27d * a * a * d) 
                / (2d * Math.Pow(Math.Abs(delta), 1.5));

            if (delta > 0)
            {
                if (Math.Abs(k) <= 1)
                {
                    Console.WriteLine("Phuong trinh co 3 nghiem:");
                    Console.WriteLine("x1 = {0}", (2d * Math.Sqrt(delta) * Math.Cos(Math.Acos(k) / 3) - b) / (3d * a));
                    Console.WriteLine("x2 = {0}", (2d * Math.Sqrt(delta) * Math.Cos(Math.Acos(k) / 3 - 2d / 3d * Math.PI) - b) / (3d * a));
                    Console.WriteLine("x3 = {0}", (2d * Math.Sqrt(delta) * Math.Cos(Math.Acos(k) / 3 + 2d / 3d * Math.PI) - b) / (3d * a));
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem thuc:");
                    Console.WriteLine("x = {0}", Math.Sqrt(delta) * Math.Abs(k) / (3d * a * k)
                        * (Math.Pow(Math.Abs(k) + Math.Sqrt(k * k - 1), 1d / 3) + Math.Pow(Math.Abs(k) - Math.Sqrt(k * k - 1), 1d / 3))
                        - (b / 3d * a));
                }
            }
            else if (delta == 0)
            {
                if ((b * b * b - 27d * a * a * d) == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem boi:");
                    Console.WriteLine("x = {0}", -b / (3d * a));
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem thuc:");
                    Console.WriteLine("x = {0}", (-b + Math.Pow(b * b * b - 27d * a * a * d, 1d / 3)) / (3d * a));
                }
            }
            else
            {
                Console.WriteLine("Phuong trinh co 1 nghiem thuc:");
                Console.WriteLine("x = {0}",
                    (Math.Sqrt(-delta) * (Math.Pow(k + Math.Sqrt(k * k + 1), 1d / 3) + Math.Pow(k - Math.Sqrt(k * k + 1), 1d / 3)) - b) 
                    / (3d * a));
            }
        }

    }
}
