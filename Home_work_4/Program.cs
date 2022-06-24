/*Напишите программу, 
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
Console.WriteLine("Please, enter the number which is greater than one:");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > 1)
{
for (int i = 1; i<number; i++)
{
 if (i % 2 == 0)
{
    Console.Write($"{i}, ");
}
}
Console.Write(number);
}
else
{
   Console.WriteLine("Please, enter the number which is greater than one:"); 
}
*/
Console.WriteLine("Please, enter the number which is greater than one:");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > -2 && number < 2)
{
  Console.WriteLine("The entered value must be different from -1,0 and 1");  
}
else
{
if (number > 1)
{
for (int i = 1; i<number; i++)
{
 if (i % 2 == 0)
{
    Console.Write($"{i}, ");
}
}
Console.Write(number);
}
else
{
   for (int i = -1; i>number; i--)
{
 if (i % 2 == 0)
{
    Console.Write($"{i}, ");
}
}
Console.Write(number);
}
}
