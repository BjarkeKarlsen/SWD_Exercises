using System;
namespace Exercise5
{
    public class ArrayGenerator
    {
        private int n_;
        private int seed_;
        private int[] array_;

        public ArrayGenerator(int n, int seed)
        {
            n_ = n;
            seed_ = seed;
        }

        public void Generate()
        {
            int[] array = new int[n_];
            Random rnd = new Random();


            for (int i =0;i<n_;i++)
            {
                array[i] = rnd.Next(seed_);
            }
            array_ = array;
        }

        public void print()
        {
            foreach (var item in array_)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n");

        }

        public int[] GetArray()
        {
            return array_;
        }
    }
}


