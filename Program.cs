using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get length of rectangle
            // get width of rectangle
            // Calculate area and perimeter
            // display those values
            // make new github
            // push to github

            Console.WriteLine("What is the length of your rectangle?" );
            string length = Console.ReadLine();
            double length1 = double.Parse(length);
            Console.WriteLine("What is the width of the rectangle");
            string width = Console.ReadLine();
            double width1 = double.Parse(width);

            double area = length1 * width1;
            double perimeter = (length1 * 2) + (width1 * 2);

            Console.WriteLine("The area of the rectangle is " + area + " and the perimeter of the rectangle is " + perimeter);


        }
    }
}
