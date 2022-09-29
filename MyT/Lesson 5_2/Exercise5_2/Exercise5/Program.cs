using Exercise5;
using System;

ArrayGenerator array1 = new ArrayGenerator(10,10);
array1.Generate();
array1.print();

int[] array2 = array1.GetArray();

InsertionSort sortedArray = new InsertionSort(array2);
sortedArray.print();