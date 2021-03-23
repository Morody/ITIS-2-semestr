using System;

namespace делегат
{
    class Program
    {
        delegate int pd (int a, int b, int c);
        static void Main(string[] args)
        {


            pd[] delegates = new pd[3];
            delegates[0] = NumberOne; 
            delegates[1] = NumberTwo;
            delegates[2] = NumberThree;

            
            int a = delegates[0].Invoke(0,0,0);
            int b = delegates[1].Invoke(0,0,0);
            int c = delegates[2].Invoke(0,0,0);

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");



             pd show = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };


            int d = show(a,b,c);
            Console.WriteLine(d); // Какое значение в анонимный метод нужно закинуть?
            
        }


        static int NumberOne(int a, int b, int c)
        {
            Random rnd = new Random();
            return rnd.Next(0,10);
        }

        static int NumberTwo(int a, int b, int c)
        {
            Random rnd = new Random();
            return rnd.Next(0,10);
        }

        static int NumberThree(int a, int b, int c)
        {
            Random rnd = new Random();
            return rnd.Next(0,10);
        }

    }
}