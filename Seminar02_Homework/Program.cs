/*
//Задача 10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Digit1(int number)
{
    int dec = number / 10;
    int second_digit = dec % 10;
    Console.WriteLine("The second digit is " + second_digit);
}

Console.Clear();
Console.Write("Input 3 digit number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 99 && user_number < 1000 || user_number > -1000 && user_number < -99)
{
    Digit1(Math.Abs(user_number));
}
else
{
    Console.WriteLine("Imposible value.");    
}
*/
/*
//Задача 13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int user_number)
{
    int temp=user_number;
    int num=user_number;
    int digit=0;
    
    while(temp>0)
    {
        temp=temp/10;
        digit++;
    }
    Console.WriteLine($"You have {digit} digits in your number.");
    if(digit<3)
    {
        Console.WriteLine("Your number is below 100.");
    }
    else
    {
        Console.WriteLine("The third digit is " + (num/(Convert.ToInt32(Math.Pow(10, digit-3))))%10);
    }
}

Console.Clear();
Console.Write("Input any number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

user_number=Math.Abs(user_number);
ThirdNumber(user_number);
*/
/*
//Задача 15
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

void Day(int week)
{
    if (week>5)
    {
        Console.WriteLine("This is a weekend.");
    }
    else
    {
        Console.WriteLine("This is a working day.");
    }
}

Console.Clear();
Console.Write("Input the number of the day of the week: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >= 1 && user_number <= 7)
{
    Day(user_number);
}
else
{
    Console.WriteLine("Imposible value.");    
}
*/