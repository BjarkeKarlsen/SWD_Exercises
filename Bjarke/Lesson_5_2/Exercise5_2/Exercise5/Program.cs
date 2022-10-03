using Exercise5;
using System;

var array1 = new ArrayGenerator(10, 10);
array1.Generate();
array1.Print();

var array2 = array1.GetArray();

var sortedArray = new InsertionSort(array2);
sortedArray.Print();