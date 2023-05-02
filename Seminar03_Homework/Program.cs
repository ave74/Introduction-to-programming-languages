//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Clear();
void Palindrom(int p1, int p2, int p4, int p5)
{
    if (p1==p5 && p2==p4)
        Console.WriteLine("Your number is palindrom.");
    else
        Console.WriteLine("Your number is NOT palindrom.");
}

Console.WriteLine("Input five digit number: ");
int n=Convert.ToInt32(Console.ReadLine());

if (n>9999 && n<100000)
{
    int pal1=n/10000%10;
    int pal2=n/1000%10;
    int pal4=n/10%10;
    int pal5=n%10;

    Console.WriteLine(pal1 + " " + pal2 + " " + pal4 + " " + pal5);
    Palindrom (pal1, pal2, pal4, pal5);
}
else
{
    Console.WriteLine("You have entered non five digit number.");
}
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3d пространстве.
/*
Console.Clear();
double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)+(z1-z2)*(z1-z2));
    return lengthAB;
}

Console.WriteLine("Input x coordinate of A: ");
int xCoordA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinate of A: ");
int yCoordA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z coordinate of A: ");
int zCoordA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x coordinate of B: ");
int xCoordB=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinate of B: ");
int yCoordB=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z coordinate of B: ");
int zCoordB=Convert.ToInt32(Console.ReadLine());

double dist=LongLine(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);

Console.WriteLine($"Distance AB is {dist:f2}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Clear();

void Cube (int num)
{
    int count = 1;
    Console.WriteLine("Cubes of numbers from 1 to " + num + ":");
    while (count <= num)
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count++;
    }
}

Console.Write("Input integer number > 0: ");
int n = Convert.ToInt32(Console.ReadLine());

Cube (n);
*/