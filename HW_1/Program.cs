/* 
Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число большее,
а какое меньшее.

a = 5    b = 7  -> max = 7 
a = 2    b = 10 -> max = 10 
a = -9   b = -3 -> max = -3 
*/

Console.Clear(); 
Console.WriteLine("Задача 2: нахождение максимального и минимального числа");  
Console.WriteLine("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA>NumberB)
{
    System.Console.WriteLine($"Максимальное = {NumberA}  Минимальное = {NumberB}");
    }
else
{
    System.Console.WriteLine($"Максимальное = {NumberB} Минимальное = {NumberA}");
    }
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

/*
Задача 4: Напишите программу, которая принимает на вход
три числа и выдаёт максимальное из этих чисел.

2, 3, 7   -> 7 
44, 5, 78 -> 78 
22, 3, 9  -> 22
*/

Console.Clear();
Console.WriteLine("Задача 4: нахождение максимального значения трех чисел");  
Console.WriteLine("Введите перое число: ");
int NumberA1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int NumberB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int NumberC1 = Convert.ToInt32(Console.ReadLine());
int Max = NumberA1;

if(Max < NumberB1)
{
    Max = NumberB1;
}
if(Max < NumberC1)
{
    Max = NumberC1;
}
Console.WriteLine($"Максимальное число -> {Max}");

Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

/*
Задача 6: Напишите программу, которая на вход 
принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да -3 -> нет 7 -> нет
*/

Console.Clear();
Console.WriteLine("Задача 6: проверка числа на четность");  
Console.WriteLine("Введите число: ");
int NumberA2 = Convert.ToInt32(Console.ReadLine());

if(NumberA2 % 2 == 0)
{
    Console.WriteLine($"{NumberA2} -> Да");
}
else
{
    Console.WriteLine($"{NumberA2} -> Нет");
}
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

/*
Задача 8: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.

5 -> 2, 4, 8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.WriteLine("Задача 8: вывод четных чисел от 1 до N");  
Console.WriteLine("Введите число: ");
int NumberA3 = Convert.ToInt32(Console.ReadLine());
int NumberPositiv = 2;
int NumberNegativ = -2;
if((NumberA3 == 1)||(NumberA3 == 0)||(NumberA3 == -1))
{
    Console.WriteLine("в данном диапазоне нет решения");
}
else if(NumberA3 > 0)
{
Console.Write($"{NumberA3} -> ");
    while (NumberPositiv<=NumberA3)
    {
        Console.Write($"{NumberPositiv} "); NumberPositiv+=2;    
    } 
}
else 
{
    Console.Write($"{NumberA3} -> ");
    while (NumberNegativ>=NumberA3)
    {
        Console.Write($"{NumberNegativ} "); NumberNegativ+=-2;    
    } 
}
