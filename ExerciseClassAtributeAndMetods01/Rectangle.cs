using System;
using System.Globalization;

namespace ExerciseClassAtributeAndMetods01
{
    class Rectangle
    {

        public double Width;
        public double Heigth;
        public double Area()
        {
            return Width * Heigth;
        }

        public double Perimeter()
        {
            return (2 * Width) + (2 * Heigth); 
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Width, 2.0)) + (Math.Pow(Heigth, 2.0)));
        }

    }
}
