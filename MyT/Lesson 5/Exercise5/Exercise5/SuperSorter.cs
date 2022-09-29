using System;
namespace Exercise5
{
    public class SuperSorter
    {
        private int[] data_;
        public SuperSorter(int[] data)
        {
 
            data_ = data;
            IntArrayInsertionSort(data_);
 
        }

        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        
        public void print()
        {
            foreach (var item in data_)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n");
        }

    }
}

