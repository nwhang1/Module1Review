using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace M1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Circle Method
            Console.WriteLine("Let's calculate the area of a Circle, what is the radius?");
            
            // Utilizing the double method, which allows for decimals to be used and returned
            double rad = double.Parse(Console.ReadLine());
            double circleArea = Cir(rad);

            Console.WriteLine($"The area of this circle is {circleArea}");

            //Triangle Method
            Console.WriteLine("Let's calculate the area of a Triangle, what is the base length and the height?");
            double baseLength = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triArea = Tri(baseLength, height);

            Console.WriteLine($"The area of this triangle is {triArea}");

            //Rectangle Method
            Console.WriteLine("Let's calculate the area of a Rectangle, what is the length and the width?");
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double rectArea = Rect(length, width);

            Console.WriteLine($"The area of this rectangle is {rectArea}");
            //Square Method
            Console.WriteLine("Let's calculate the area of a Square, what is the length of one side?");
            double side = double.Parse(Console.ReadLine());
            double sqArea = Sq(side);

            Console.WriteLine($"The area of this square is {sqArea}");
        }
        static double Cir(double rad)
        {
            return rad * rad * 3.14;
        }

        static double Tri(double baseLength, double height)
        {
            return baseLength * height * .5;
        }

        static double Rect(double length, double width)
        {
            return length * width;
        }

        static double Sq(double side)
        {
            return side * side;
        }
    }
}
