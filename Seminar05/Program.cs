//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
/*
Console.Clear();
int [] CreateRandomArray (int size, int minVal, int maxVal)
{
    int [] newArray = new int [size];

    for (int i=0; i<size; i++)
        newArray[i]=new Random().Next(minVal, maxVal+1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for (int i=0; i<array1.Length; i++)
        Console.Write(array1 [i] + " ");
    Console.WriteLine();
}

int FindSumNegativeElem (int [] array)
{
    int summNegative=0;
    for (int i=0; i<array.Length; i++)
        if (array[i]<0) summNegative+=array[i];
    return summNegative;
}

int FindSumPositiveElem (int [] array)
{
    int summPositive=0;
    for (int i=0; i<array.Length; i++)
        if (array[i]>0) summPositive+=array[i];
    return summPositive;
}

int sizeArray = 12;
int minVal = -9;
int maxVal = 9;

int [] createdArray = CreateRandomArray(sizeArray, minVal, maxVal);
ShowArray(createdArray);
Console.WriteLine($"Sum of positive elements is {FindSumPositiveElem(createdArray)}");
int resultNegative = FindSumNegativeElem(createdArray);
Console.WriteLine($"Sum of negative elements is {resultNegative}");
*/

//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат записать в новом массиве.
//[1 2 3 4 5] -> [5 8 3]
//[6 7 3 6] -> [36 21]
/*
Console.Clear();
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine();
}

int[] FindMultiPar(int [] arrayForMulti)
{
    int sizeTemp;
    if (arrayForMulti.Length % 2 == 0)
        sizeTemp = arrayForMulti.Length / 2;
    else sizeTemp = (arrayForMulti.Length + 1) / 2;

    int[] arrayMulti = new int[sizeTemp];

    for (int i = 0; i < sizeTemp; i++)
    {
        arrayMulti[i]=arrayForMulti[i]*arrayForMulti[arrayForMulti.Length-1-i];
    }
    if (arrayForMulti.Length %2 != 0)
        arrayMulti[sizeTemp-1]=arrayForMulti[sizeTemp-1];
    return arrayMulti;
}

int sizeArray = 5;
int minVal = 0;
int maxVal = 9;

int[] arrayStart = CreateRandomArray(sizeArray, minVal, maxVal);
ShowArray(arrayStart);
int [] arrayFinish = FindMultiPar(arrayStart);
ShowArray(arrayFinish);
*/

//Найдите одномерный массив из 123 случайных чисел
//Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123.
//[5 18 123 6 2] -> 1
//[1 2 3 6 2] -> 0
//[10 11 12 13 14] -> 5

Console.Clear();
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray(int[] array1)
{
    int count=0;
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
        if (array1 [i]>=10 && array1[i]<=99)
           count+=1;
    }
    Console.WriteLine();
    Console.Write($"There are {count} numbers between 10 and 99");
}

int sizeArray = 5;
int minVal = 0;
int maxVal = 200;

int[] arrayStart = CreateRandomArray(sizeArray, minVal, maxVal);
ShowArray(arrayStart);
//int [] arrayFinish = FindMultiPar(arrayStart);
//ShowArray(arrayFinish);
