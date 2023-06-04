//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
//а первый - на последнем и т.д.)
/*
Console.Clear();
int[] CreateNewArray(int size, int minVal, int maxVal)
{
    int[] array1 = new int[size];
    for (int i = 0; i < size; i++)
        array1[i] = new Random().Next(minVal, maxVal + 1);
    return array1;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] ReverseArray(int[] startArray)
{
    int l = startArray.Length;
    for (int i = 0; i < l / 2; i++)
    {
        int temp = startArray[i];
        startArray[i] = startArray[l - 1 - i];
        startArray[l - 1 - i] = temp;
    }
    return startArray;
}

int sizeArray = 7;
int minVal = 0;
int maxVal = 9;

int[] newArray = CreateNewArray(sizeArray, minVal, maxVal);
PrintArray(newArray);
int[] reversedArray = ReverseArray(newArray);
PrintArray(reversedArray);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b (пользователь).
/*
Console.Clear();
void ArrFib (int count, int first, int second)
 {
    int [] fibArray = new int [count];
    fibArray[0]=first;
    fibArray[1]=second;
    for (int i=2; i<count; i++)
        fibArray[i]=fibArray[i-1]+fibArray[i-2];
    PrintArray(fibArray);
 }

 void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input count of elements:");
int countOfElem = Convert.ToInt32(Console.ReadLine());

if (countOfElem<2)
{
    while (countOfElem<2)
    {
        Console.WriteLine("Impossible value");
        Console.WriteLine("Imput count of elements: ");
        countOfElem = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Input first element:");
int firstElem = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second element:");
int secondElem = Convert.ToInt32(Console.ReadLine());

ArrFib (countOfElem, firstElem, secondElem);
*/

//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длины.
//Треугольник существует если каждая сторона треугольника меньше суммы двух других сторон.

bool Triangle (int side1, int side2, int side3)
{
    if (side1<side2+side3 && side2<side1+side3 && side3<side2+side1)
        return true;
    else return false;
}

Console.Write("Input first side: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second side: ");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third side: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(firstSide, secondSide, thirdSide);

if (result==true) Console.WriteLine("Triangle exists");
else Console.WriteLine("Triangle does not exist");