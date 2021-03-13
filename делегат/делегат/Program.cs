using System;

namespace делегат
{
    class Program
    {
        delegate double Message(double r);
        static void Main(string[] args)
        {
            var r = Convert.ToDouble(Console.ReadLine());
            Message text = new Message(LengthCircle);
            Console.WriteLine(text(r));
            text = SquareCircle;
            Console.WriteLine(text(r));
            text = SphereVolume;
            Console.WriteLine(text(r));

        }
        static double LengthCircle(double r)
        {
            return 2 * Math.PI * r;
        }
        static double SquareCircle(double r)
        {
            return Math.PI * r * r;
        }
        static double SphereVolume(double r)
        {
            return 4 / 3 * Math.PI * r * r * r;
        }



    }
}
