using System;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine("Phuong trinh co nghiem" + -b / a);
            }
            else
            {
                if (b == 0) Console.WriteLine("Phuong trinh vo so nghiem");
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
        }
    }
}

