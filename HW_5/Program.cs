#nullable disable
//https://learn.microsoft.com/ru-ru/dotnet/api/system.string.split?view=net-7.0
//методы:
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

int CountEvenNum(int[] array)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int CountOddIndex (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

double[] RandomDoubleArray(int length, int minValue, int maxValue)
{ 
    double[] doubles = new double[length];
    var random = new Random();

    for (int i = 0; i < length; i++)
    {
        doubles[i] = Convert.ToDouble(random.Next(-100, 100)/10.0);
    }
    return doubles;
}

double DifferenceMinMax(double[] array)  
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

//добавить кейс
Console.Clear();
Console.WriteLine("Задача 34: подсчет количества чётных чисел в массиве");
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
OutputArray(array); Console.Write($" -> {CountEvenNum(array)}");
Console.WriteLine("\nДля продолжения нажмите любую клавишу..." );
Console.ReadKey();
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//добавить кейс
Console.Clear();
Console.WriteLine("Задача 36: вычисление суммы элементов в нечётных индексах");
Console.Write("Длинна массива: "); // не может быть равной нулю, отрицательной и дробной || (length % 10) > 0
int length2;
if (!int.TryParse(Console.ReadLine(), out length2) || length2 <= 0)
{
  Console.WriteLine("Некорректный ввод");
  return;
}
min = InputUser("Начальное значение массива: ");
max = InputUser("Конечное значение массива: ");
array = GenerateArray(length2, min, max);
OutputArray(array); Console.Write($" -> {CountOddIndex(array)}");
Console.WriteLine("\nДля продолжения нажмите любую клавишу..." );
Console.ReadKey();
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
//добавить кейс
Console.Clear();
Console.WriteLine("Задача 38: вычисление разницы между максимальным и минимальным элементами");
Console.Write("Длинна массива: "); // не может быть равной нулю, отрицательной и дробной || (length % 10) > 0
int length3;
if (!int.TryParse(Console.ReadLine(), out length3) || length3 <= 0)
{
  Console.WriteLine("Некорректный ввод");
  return;
}
min = InputUser("Начальное значение массива: ");
max = InputUser("Конечное значение массива: ");
double[] Darray = RandomDoubleArray(length3, min, max);
Console.Write(String.Join(" ", Darray));
Console.Write($"-> {DifferenceMinMax(Darray)}");
Console.WriteLine("\nДля продолжения нажмите любую клавишу..." );
Console.ReadKey();