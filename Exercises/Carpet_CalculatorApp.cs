using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Exercises
{
    public class Carpet_CalculatorApp
    {

        public Carpet_CalculatorApp()
        {

        }

        public void CalculateCarpet()
        {
            Console.WriteLine("Welcome to your local carpet store!" +
                " To calculate how much carpet you need please input length and width");

            Console.WriteLine("Input the lenght of the room");
            double roomLenght = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the width of the room");
            double roomWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The carpet price per square foot for is: 4.99!");
            double carpetingPrice = 4.99;
            double carpetAreaTotal = roomLenght * roomWidth;
            double carpetPriceTotal = carpetAreaTotal * carpetingPrice;
            Console.WriteLine("");

            Console.WriteLine($"Total area in square foot: {carpetAreaTotal }.");
            Console.WriteLine($"Calculated price: € {carpetPriceTotal}.");

        }
    }
}
