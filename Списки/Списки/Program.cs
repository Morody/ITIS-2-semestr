using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списки
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstA = new List<int>() { 1, 2, 3, 4, 5 };
            var lstB = lstA.Select((x, i) => x = lstA.Take(i + 1).Sum()).ToList();
            Console.WriteLine(string.Join(" ", lstB));

        }
    }
}
