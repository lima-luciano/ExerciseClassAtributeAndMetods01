using System;
using System.Globalization;

namespace ExerciseClassAtributeAndMetods01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle x = new Rectangle();
            
            Console.WriteLine("Type the width and height of rectangle: ");
            x.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
