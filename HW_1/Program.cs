/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 
a = 2 b = 10 -> max = 10 
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Enter number A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA>NumberB)
{
    System.Console.WriteLine($"Max = {NumberA}  Min = {NumberB}");
    }
else
{
    System.Console.WriteLine($"Max = {NumberB} Min = {NumberA}");
    }


