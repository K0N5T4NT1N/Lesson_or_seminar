#nullable disable
int InputUser(string message)
{
    Console.WriteLine(message);
    string ReadVoid =  Console.ReadLine();
    int result = int.Parse(ReadVoid);
    return result;    
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void OutputArray (int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");      
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int CountHonest(int[] array)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
//https://learn.microsoft.com/ru-ru/dotnet/api/system.string.split?view=net-7.0


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Write("Длинна массива: "); // не может быть равной нулю, отрицательной и дробной || (length % 10) > 0
int length; 
if (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
{
  Console.WriteLine("Некорректный ввод");
  return;
}
int min = 100; //InputUser("Начальное значение массива: ");
int max = 999; //InputUser("Конечное значение массива: ");
int[] array = GenerateArray(length, min, max);
OutputArray(array); Console.Write($" -> {CountHonest(array)}");

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/