//Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
//двумерного массива.
/*
Console.Clear();
int[,] Create2DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] created2Array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return created2Array;
}

void Print2Array(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Sort2dArray(int[,] arrayToSort)
{
    int lr = arrayToSort.GetLength(0);
    int lc = arrayToSort.GetLength(1);

    for (int i = 0; i < lr; i++)
    {
        for (int z = 0; z < lc; z++)
        {
            int max = arrayToSort[i, z];
            int temp;
            for (int j = z; j < lc; j++)
            {
                if (arrayToSort[i, z] < arrayToSort[i, j])
                {
                    temp=arrayToSort[i,z];
                    arrayToSort[i,z] = arrayToSort[i, j];
                    arrayToSort[i,j]=temp;
                } 
            }
        }
    }
    return arrayToSort;
}

int[,] new2dArray = Create2DArray();
Print2Array(new2dArray);
Sort2dArray(new2dArray);
Print2Array(new2dArray);
*/


//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов
/*
Console.Clear();
int[,] Create2DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] created2Array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return created2Array;
}

void Print2Array(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumRows (int[,] rowsToSum)
{
    int lr = rowsToSum.GetLength(0);
    int lc = rowsToSum.GetLength(1);
    int[] sumArray = new int[lr];

    for (int i = 0; i < lr; i++)
    {
        int sum=0;
        for (int j = 0; j < lc; j++)
        {
            sum += rowsToSum[i, j];
        }
        sumArray[i]= sum;
    }

    int min=sumArray[0];
    int i_min=0;
    for (int i=1; i<lr; i++)
    {
        if (min>sumArray[i]) 
        {
            min=sumArray[i];
            i_min=i;
        }
    }

    Console.WriteLine($"Minimum sum {min} has row number {i_min+1}");
}

int[,] new2dArray = Create2DArray();
Print2Array(new2dArray);
SumRows (new2dArray);
*/

//Задача 58. Задайте 2 матрицыю Напишите программу, которая будет находить произведение 2х матриц.
/*
Console.Clear();
int[,] Create2DArray()
{
    int rows = 4;
    int columns = 4;
    int minVal = 1;
    int maxVal = 10;

    int[,] created2Array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return created2Array;
}

void Print2Array(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiMatrix(int[,] matrixA, int[,] matrixB)
{
    int lrA = matrixA.GetLength(0);
    int lcA = matrixA.GetLength(1);
    int lrB = matrixB.GetLength(0);
    int lcB = matrixB.GetLength(1);
    int sum = 0;

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int z = 0; z < lcB; z++)
    {
        for (int i = 0; i < lcA; i++)
        {
            sum = 0;
            for (int j = 0; j < lrB; j++)
            {
                sum = sum + matrixA[i, j] * matrixB[j, z];
            }
            matrixC[i, z] = sum;
        }

    }
    return matrixC;
}

Console.WriteLine("///////////////////////////////////////////////////");
Console.WriteLine("First matrix is:");
int[,] array2dA = Create2DArray();
Print2Array(array2dA);

Console.WriteLine("Second matrix is:");
int[,] array2dB = Create2DArray();
Print2Array(array2dB);

Console.WriteLine("Result of matrix multiplication is:");
Print2Array(MultiMatrix(array2dA, array2dB));
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента
/*
Console.Clear();
int[,,] Create3DArray()
{
    int rows = 4;
    int columns = 4;
    int depth = 4;
    int minVal = 10;
    int temp = minVal;

    int[,,] created3Array = new int[rows, columns, depth];

    for (int z = 0; z < depth; z++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                created3Array[i, j, z] = temp + 1;
                temp = temp + 1;
            }
        }
    }
    return created3Array;
}

void Print3Array(int[,,] array3d)
{
    for (int z = 0; z < array3d.GetLength(2); z++)
    {
        for (int i = 0; i < array3d.GetLength(0); i++)
        {
            for (int j = 0; j < array3d.GetLength(1); j++)
            {
                Console.Write(array3d[i, j, z] + " (" + i + ", " + j + ", " + z + ")" + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("3d matrix is:");
int[,,] array3d = Create3DArray();
Print3Array(array3d);
*/
//Задача 62. Напишите программу, которая заполнит спиралью массив 4 на 4.

//???????????????????????????
