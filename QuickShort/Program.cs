using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShort
{
    class Program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movements

        // number of element in array
        private int n;


        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray Can Have Maximum 20 Elements \n");
            }
            Console.WriteLine("\n==============================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n==============================");
        }
        static void Main(string[] args)
        {
        }
    }
}
