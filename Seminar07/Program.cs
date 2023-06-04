//Задайте двумерный массив размером m x n, заполненный случайными целыми числами.
//m=3, n=4
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

Console.Clear();
int [,] Create2DArray ()
{
    Console.Write("Input number of rows: ");
    int rows=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimum: ");
    int minVal=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum: ");
    int maxVal=Convert.ToInt32(Console.ReadLine());

    int [,] created2Array = new int [rows, columns];

    for (int i = 0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            created2Array[i, j]=new Random().Next(minVal, maxVal+1);
        }
    }
    return created2Array;
}

void Print2Array (int [,] array2d)
{
    for (int i=0; i<array2d.GetLength(0); i++)
    {
        for (int j=0; j<array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] new2dArray = Create2DArray ();
Print2Array(new2dArray);