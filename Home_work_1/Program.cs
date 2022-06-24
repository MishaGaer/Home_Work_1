/*Напишите программу, 
которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Please, enter the first number:");
string firstNumber = Console.ReadLine();
Console.WriteLine("Please, enter the second number:");
string secondNumber = Console.ReadLine();
int first = int.Parse (firstNumber);
int second = int.Parse (secondNumber);
if (first == second)
{
    Console.WriteLine($"Number {first} is equal to number {second}");
}
else
{
if (first > second)
{
    Console.WriteLine($"Number {first} is greater than number {second}");
}
else 
{
    Console.WriteLine($"Number {second} is greater than number {first}");
}
}