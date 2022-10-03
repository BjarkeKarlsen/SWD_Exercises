using System;
namespace Exercise5
{
    public class ArrayGenerator
    {
        private readonly int _n;
        private readonly int _seed;
        private int[] _array;

        public ArrayGenerator(int n, int seed)
        {
            _n = n;
            _seed = seed;
            _array = new int[8];
        }

        public void Generate()
        {
            var array = new int[_n];
            var rnd = new Random();

            for (var i = 0; i < _n; i++)
            {
                array[i] = rnd.Next(_seed);
            }
            _array = array;
        }

        public void Print()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n");

        }

        public int[] GetArray()
        {
            return _array;
        }
    }
}


