/*
string [,] table = new string[2, 5];
table[1, 2] = "word";
for (double rows=0; rows<2; rows++)
{
    for (double columns=0; columns<5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

/*
void PrintArray(double[,] image)
{
    for (double i = 0; i < image.GetLength(0); i++)
    {
        for (double j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(double[,] image)
{
    for (double i = 0; i < image.GetLength(0); i++)
    {
        for (double j = 0; j < image.GetLength(1); j++)
        {
            image[i, j] = new Random().Next(1, 10);
        }
    }
}

double[,] matrix = new double[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
*/

/*
double[,] pic = new double[,]
{
    { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,1,1,0,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,1,1,0,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};


void PrintImage(double[,] image)
{
    for (double i = 0; i < image.GetLength(0); i++)
    {
        for (double j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillImage(double row, double col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}


PrintImage(pic);
FillImage(5, 13);
PrintImage(pic);
*/
/*
double Factorial(double n)
{
    if (n==1) return 1;
    else return n*Factorial(n-1);
}

Console.WriteLine(Factorial(5));
*/
/*
double Factorial(double n)
{
    if (n==1) return 1;
    else return n*Factorial(n-1);
}
for (double i=1; i<40; i++)
{
    Console.WriteLine(Factorial(i));
}
*/

double Fibonacci (double n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}
for (double i=1; i<40; i++)
{
    Console.WriteLine(Fibonacci(i));
}