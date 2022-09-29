using System;
namespace Exercise5
{
    class InsertionSort: SuperSorter
    {
        
        private readonly int[] _data;

        public InsertionSort(int[] data) : base(data)
        {
            _data = data;
            algorithm();
        }

        protected override void algorithm()
        {
            int i, j;
            int N = _data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && _data[i] < _data[i - 1]; i--)
                {
                    exchange(_data, i, i - 1);
                }
            }
        }

    }
}

