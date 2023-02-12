int Degree(int NumA, int NumB)
{
    int result = 1;
    for (int i = 1; i <= NumB; i++)
    {
        result *= NumA;
    }
    return result;
}

int SumN(int NumN)
{
    int result = 0;
    while (NumN>0)
    {
        result += NumN % 10; NumN /= 10;
    }
    return result;
}

int[] randomArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}


/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
Console.WriteLine("Задача 25: Возведение A в степень B");
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

Console.Clear();
Console.WriteLine("Задача 27: Суммма цифр числа N");
Console.WriteLine("Введите число: ");
int NumN = int.Parse(Console.ReadLine());

Console.WriteLine($"{NumN} -> {SumN(NumN)}");
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

/*
Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();
Console.WriteLine("Задача 29: генерация массива из N элементов");
Console.WriteLine("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение массива: ");
int minValue = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение массива: ");
int maxValue = int.Parse(Console.ReadLine());

int[] array = randomArray(length, minValue, maxValue);
Console.Write($"[{String.Join(",", array)}]");
Console.ReadKey();