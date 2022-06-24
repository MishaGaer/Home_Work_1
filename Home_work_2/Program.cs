/*
Напишите программу, 
которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Please, enter the first number:");
string firstNumber = Console.ReadLine();
Console.WriteLine("Please, enter the second number:");
string secondNumber = Console.ReadLine();
Console.WriteLine("Please, enter the third number:");
string thirdNumber = Console.ReadLine();

int first = int.Parse (firstNumber);
int second = int.Parse (secondNumber);
int third = int.Parse (thirdNumber);

if (first > second)
{
    if (first > third)
    {
        Console.WriteLine(first);
    }
    else
    {
        Console.WriteLine(third);
    }
}
else
{
    if (second > third)
    {
        Console.WriteLine(second);
    }
    else
    Console.WriteLine(third);
}