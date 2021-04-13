using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> listnumber = new LinkedList<int>();
            listnumber.Add(5);
            listnumber.Add(7);
            listnumber.Add(10);
            listnumber.Add(8);
            listnumber.Add(9);

        }
        static void PrintList(LinkedList<int> List)
        {
            var node = List.First;


        }
    }
}
