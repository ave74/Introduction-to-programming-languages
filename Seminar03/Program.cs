//Задача 1
//Напишите программу, которая принимает на вход координаты точки (х и у),
//причём х!=0 и у!=0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
Console.Clear();
void Coords(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("This point is on 1st quater");
    else if (x < 0 && y > 0)
        Console.WriteLine("This point is on 2st quater");
    else if (x < 0 && y < 0)
        Console.WriteLine("This point is on 3rd quater");
    else
        Console.WriteLine("This point is on 4th quater");
}

Console.WriteLine("Enter your x coordinate: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your y coordinate: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

if (xCoord == 0 || yCoord == 0)
    Console.WriteLine("Its impossible value for this task");
else
    Coords(xCoord, yCoord);
*/
/*
//Задача 1_1

Console.Clear();
int Coords(int x, int y)
{
    int number_quater;
    if (x > 0 && y > 0)
        //Console.WriteLine("This point is on 1st quater");
        number_quater=1;
    else if (x < 0 && y > 0)
        //Console.WriteLine("This point is on 2st quater");
        number_quater=2;
    else if (x < 0 && y < 0)
        //Console.WriteLine("This point is on 3rd quater");
        number_quater=3;
    else
        //Console.WriteLine("This point is on 4th quater");
        number_quater=4;
    return number_quater;
}

Console.WriteLine("Enter your x coordinate: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your y coordinate: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

if (xCoord == 0 || yCoord == 0)
    Console.WriteLine("Its impossible value for this task");
else
    Coords(xCoord, yCoord);
    int res=Coords(xCoord, yCoord);
    Console.WriteLine($"This point is on quater number {res}");
*/

//Задача 2
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
//координат точек в этой четверти (х и у)
/*
Console.Clear();
void PossibleValue (int num)
{
    if (num==1)
        Console.WriteLine("1st quater x>0, y>0");
    else if (num==2)
        Console.WriteLine("2nd quater x<0, y>0");
    else if (num==3)
        Console.WriteLine("3rd quater x<0, y<0");
    else
        Console.WriteLine("4th quater x>0, y<0");
}

Console.WriteLine("Input number of quater: ");
int numQuater=Convert.ToInt32(Console.ReadLine());

if (numQuater>=1 && numQuater<=4)
    PossibleValue(numQuater);
else Console.WriteLine("It is not mumber of quater!");
*/
/*
//Задача 3
//Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве

Console.Clear();
double LongLine(int x1, int x2, int y1, int y2)
{
    double lengthAB = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return lengthAB;
}

Console.WriteLine("Input x coordinate of A: ");
int xCoordA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinate of A: ");
int yCoordA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x coordinate of B: ");
int xCoordB=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinate of B: ");
int yCoordB=Convert.ToInt32(Console.ReadLine());

double dist=LongLine(xCoordA, xCoordB, yCoordA, yCoordB);

Console.WriteLine($"Distance AB is {dist:f3}");
*/

