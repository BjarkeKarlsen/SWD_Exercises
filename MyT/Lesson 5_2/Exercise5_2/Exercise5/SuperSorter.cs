using System;
namespace Exercise5
{
    abstract class SuperSorter
    {
        private int[] data_;
        public SuperSorter(int[] data)
        {
 
            data_ = data;
        
        }

        public void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        protected abstract void algorithm();

        public void print()
        {
            foreach (var item in data_)
            {
                Console.WriteLine(item);
           
            }
            Console.WriteLine("hihi\n");
        }

    }
}

