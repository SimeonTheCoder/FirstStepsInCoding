using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args) {
            double price = 7.61;

            double area = double.Parse(Console.ReadLine());

            double money = price * area;
            double discount = money * 0.18;

            money -= discount;

            Console.WriteLine(String.Format("The final price is: {0} lv.", money));
            Console.WriteLine(String.Format("The discount is: {0} lv.", discount));
        }
    }
}