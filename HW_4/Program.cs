int Degree(int NumA, int NumB)
{
    int result = 1;
    for (int i = 1; i <= NumB; i++)
    {
        result *= NumB;
    }
    return result;
}



/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
Console.WriteLine("Введите число A: ");
int NumA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int NumB = int.Parse(Console.ReadLine());

Console.WriteLine($"{NumA}, {NumB} -> {Degree(NumA, NumB)}");
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();


/*
Задача 27: Напишите программу, которая принимает
на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/



/*
Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/