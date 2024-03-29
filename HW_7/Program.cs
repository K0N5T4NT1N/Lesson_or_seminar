﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

#nullable disable
//методы начало
int InputUser(string message)
{
    Console.Write(message);
    string ReadVoid = Console.ReadLine();
    var result = int.Parse(ReadVoid);
    return result;
}


int[,] GetMatrix(int rows, int columns, int min, int max) //двумерный массив размером m×n, заполненный случайными целыми числами.
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

double[,] GetMatrixDouble(int rows, int columns, int min, int max) //двумерный массив размером m×n, заполненный случайными вещественными числами.
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max + 1) + new Random().NextDouble();
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}

void PrintDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{Math.Round(matrix[i, l], 2)} ");
        }
        Console.WriteLine();
    }
}

void FindValue(int[,] matrix, int i, int l)
{
    if (i < matrix.GetLength(0) && l < matrix.GetLength(1))
    {
        Console.WriteLine($"{matrix[i, l]} -> число найдено!");
    }
    else
    {
        Console.WriteLine($"{i}{l} -> числа с данными индексами в массиве нет");
    }
}

double[] AverageArray(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double temp = 0;
        for (int l = 0; l < matrix.GetLength(0); l++)
        {
            temp += matrix[l, i];
        }
        result[i] = temp / matrix.GetLength(0);
    }
    return result;
}

int[,] SpiralArray(int perimetr, int filling)
{
    int rows = perimetr;
    int columns = perimetr;
    int i = 0;
    int j = 0;
    int[,] matrix = new int[rows, columns];
    while (filling <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = filling; 
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
        filling++;
    }
    return matrix;
}

//методы конец

Console.Clear();

HomeWork();

void HomeWork()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Задача 47: Создание двумерного массива размером m×n, заполненного случайными вещественными числами.\n");
        Console.WriteLine("Задача 50: Проверка позиции заданного элемента в двумерном массиве. (Возвращает значение этого элемента либо указывает, что такого элемента нет).\n");
        Console.WriteLine("Задача 52: Нахождение среднго арифметического элементов в каждом столбце заданного массива. \n");
        Console.WriteLine("Задача 62: Спиральное заполнение  массива 4 на 4. \n");
        Console.WriteLine("Для выхода введите: 0 \n");

        int numTask = InputUser("Введите номер задачи: ");

        switch (numTask)
        {
            case 0: return;

            case 47:
                Console.Clear();
                int rows = InputUser("Введите количество строк (m): ");
                int columns = InputUser("Введите количество столбцов (n): ");
                int min = InputUser("Введите минимальное значение: ");
                int max = InputUser("Введите максимальное значение: ");
                double[,] matrixDouble = GetMatrixDouble(rows, columns, min, max);
                PrintDouble(matrixDouble);
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            case 50:
                Console.Clear();
                int[,] matrix50 = GetMatrix(12, 12, 0, 20);
                int indexRow = InputUser("Введите индекс строки в массиве: ");
                int indexColumn = InputUser("Введите индекс столбца в массиве: ");
                Print(matrix50); FindValue(matrix50, indexRow, indexColumn);
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            case 52:
                Console.Clear();
                rows = InputUser("Введите количество строк: ");
                columns = InputUser("Введите количество столбцов: ");
                min = InputUser("Введите минимальное значение: ");
                max = InputUser("Введите максимальное значение: ");
                int[,] matrix52 = GetMatrix(rows, columns, min, max);
                Print(matrix52); double[] outputArray = AverageArray(matrix52);
                Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", outputArray)}");
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            case 62:
                int size = InputUser("Введите размер матрицы: ");
                int count = InputUser("Введите начальное значение: ");
                int[,] matrix62 = SpiralArray(size, count); Print(matrix62);
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            default: Console.WriteLine("Такой задачи не существует"); break;
        }
    }
}