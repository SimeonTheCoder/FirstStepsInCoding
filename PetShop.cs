using System;

namespace HelloSoftUni
{
    class Program
    {
        static double dogPrice = 2.50;
        static double otherPrice = 4;

        static void Main(string[] args) {
            int dogs = int.Parse(Console.ReadLine());
            int other = int.Parse(Console.ReadLine());

            double money = dogs * dogPrice + other * otherPrice;

            Console.WriteLine(String.Format("{0} lv.", money));
        }
    }
}