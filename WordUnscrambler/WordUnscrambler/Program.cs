using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            ListExample();
            ArrayExample();
        }

        private static void ListExample()
        {
            List<int> myList = new List<int>(); //Dynamically adjusted - no initital capacity.

            Console.WriteLine(myList.Count());

            myList.Add(10);
            myList.Add(5);

            Console.WriteLine(myList.Count());
            Console.ReadLine();
        }

        private static void ArrayExample()
        {
            int[] myArray = new int[10]; //Needs an initial capacity.
        }
    }
}
