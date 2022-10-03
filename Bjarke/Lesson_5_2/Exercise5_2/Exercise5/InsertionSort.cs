using System;
namespace Exercise5
{
    public class InsertionSort : SuperSorter
    {
        private static int[]? _data;
        public InsertionSort(int[] data) : base(data)
        {
            _data = data;
            IntArrayInsertionSort();
        }

        protected sealed override void IntArrayInsertionSort()
        {
            if (_data == null) return;

            for (var j = 1; j < _data.Length; j++)
            {
                int i;
                for (i = j; i > 0 && _data[i] < _data[i - 1]; i--)
                {
                    Exchange(_data, i, i - 1);
                }
            }
        }

    }
}

