using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1, c=0; i<=a; i++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}",i,c+=i*2-1);
            }
            Console.ReadKey();
        }
    }
}
