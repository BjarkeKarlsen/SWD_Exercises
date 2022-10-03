using System;
namespace Exercise5
{
    public abstract class SuperSorter
    {
        private readonly int[] _data;
        public SuperSorter(int[] data)
        {
            _data = data;
        }

        public void Exchange(int[] data, int m, int n)
        {
            (data[m], data[n]) = (data[n], data[m]);
        }

        protected abstract void IntArrayInsertionSort();

        public void Print()
        {
            foreach (var item in _data)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n");
        }

    }
}

