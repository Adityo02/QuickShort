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

            //get array elements
            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low < high)
                return;

            //partition the list into two parts:
            //one containing elements less that or equal to pivot
            // Outher containning elements greather than pivot

            i = low;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //Search for an element greather than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //Search for an element less than or equel to pivot
                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j) //if the element is on the left of the element
                {
                    //swap the element at index i whit the element at index j
                    swap(i, j);
                    mov_count++;
                }
            }
            //j now contains the index of the last element in the sorted list

            if (low < j)
            {
                //Move the pivot to its correct posituon in the list
                swap(low, j);
                mov_count++;
            }
            //Sort the list on the left of pivot using quicksort
            q_sort(low, j - 1);

            //Sort the list on the right of pivot using quicksort
            q_sort(j + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("\n------------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of Comparisons : " + cmp_count);
            Console.WriteLine("\nNumber of Data Movemenets : " + mov_count);
        }
        int getSize()
        {
            return (n);
        }
        static void Main(string[] args)
        {
            //Declaring the object of the class
            Program myList = new Program();
            //Accept array elemets
            myList.read();
            //Calling the sorting function
            //Frist call to quicksort algorithm
            myList.q_sort(0, myList.getSize() - 1);
            //Display sorted array
            myList.display();
            //to exit from the console
            Console.WriteLine("\n\nPress Enter to Exit");
            Console.Read();
        }
    }
}
