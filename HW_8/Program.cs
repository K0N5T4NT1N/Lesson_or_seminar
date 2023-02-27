/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

void DescendingSortOrder(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int j = l + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, l] < matrix[i, j])
                {
                    int temp = matrix[i, l];
                    matrix[i, l] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
}

void MinSumInRows(int[,] matrix)
{
    int? minSum = null;
    int indexMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            sumRow += matrix[i, l];
        }
        if (i == 0)
        {
            minSum = sumRow;
            indexMinSum = i + 1;
        }
        else if (sumRow < minSum)
        {
            minSum = sumRow;
            indexMinSum = i + 1;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой элементов -> {indexMinSum}");
}

int[,] MultiplexMatrix(int[,] first, int[,] second)
{
    int[,] multiMatrix = new int[first.GetLength(0), second.GetLength(1)];

    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int l = 0; l < second.GetLength(1); l++)
        {
            for (int k = 0; k < second.GetLength(0); k++)
            {
                multiMatrix[i, l] += first[i, k] * second[k, l];
            }
        }
    }
    return multiMatrix;
}

int[] GetShuffleArray()
{
    int[] array = new int[90];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 10;
    }

    Random fill = new Random();

    for (int i = array.Length - 1; i >= 1; i--)
    {
        int k = fill.Next(i + 1);

        int temp = array[k];
        array[k] = array[i];
        array[i] = temp;
    }
    return array;
}

int[,,] Matrix3D(int valueX, int valueY, int valueZ, int[] fill)
{
    int[,,] matrix = new int[valueX, valueY, valueZ];

    for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2);)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                for (int z = 0; z < matrix.GetLength(2); z++)
                {
                    matrix[x, y, z] = fill[i];
                    i++;
                }

            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[x, y, z]} -> ({x}, {y}, {z}) ");
            }
            Console.WriteLine();
        }
    }
}

//методы конец

Console.Clear();

HomeWork();

void HomeWork()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Задача 54: Упорядочивание по убывантю элементов двумерного массива.\n");
        Console.WriteLine("Задача 56: Поиск строки с наименьшей суммой в двумерном массиве.\n");
        Console.WriteLine("Задача 58: Нахождение произведения двух матриц\n");
        Console.WriteLine("Задача 60: Создание трехмерного массива из неповторяющихся двузначных чисел, и вывод элементов с индексами \n");
        Console.WriteLine("Для выхода введите: 0 \n");

        int numTask = InputUser("Введите номер задачи: ");

        switch (numTask)
        {
            case 0: return;

            case 54:
                Console.Clear();
                int rows = InputUser("Введите количество строк (m): ");
                int columns = InputUser("Введите количество столбцов (n): ");
                int min = InputUser("Введите минимальное значение: ");
                int max = InputUser("Введите максимальное значение: ");
                int[,] matrix54 = GetMatrix(rows, columns, min, max);
                Print(matrix54); Console.WriteLine();
                DescendingSortOrder(matrix54); Print(matrix54);
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            case 56:
                Console.Clear();
                rows = InputUser("Введите количество строк (m): ");
                columns = InputUser("Введите количество столбцов (n): ");
                min = InputUser("Введите минимальное значение: ");
                max = InputUser("Введите максимальное значение: ");
                int[,] matrix56 = GetMatrix(rows, columns, min, max);
                Print(matrix56); Console.WriteLine();
                MinSumInRows(matrix56);
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            case 58:
                Console.Clear();
                rows = InputUser("Введите количество строк для матриц: ");              //Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором; 
                columns = InputUser("Введите количество столбцов для матриц: ");        //в этом случае говорят, что матрицы согласованы. В частности, умножение всегда выполнимо, если оба сомножителя — квадратные матрицы одного и того же порядка.
                min = InputUser("Введите минимальное значение: ");
                max = InputUser("Введите максимальное значение: ");
                int[,] matrixFirst = GetMatrix(rows, columns, min, max);
                int[,] matrixSecond = GetMatrix(columns, rows, min, max);
                Print(matrixFirst); Console.WriteLine();
                Print(matrixSecond); Console.WriteLine();
                int[,] matrix58 = MultiplexMatrix(matrixFirst, matrixSecond);
                Print(matrix58);
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            case 60:
                Console.Clear();
                int sizeX = InputUser("Введите размер по оси X: ");
                int sizeY = InputUser("Введите размер по оси Y: ");
                int sizeZ = InputUser("Введите размер по оси Z: ");
                if ((sizeX * sizeY * sizeZ) > 90)
                {
                    Console.WriteLine("Слишком большой размер. Количество значений не должно превышать 90");
                    Console.ReadKey(); break;
                }
                else
                {
                    int[] fillarray = GetShuffleArray();
                    int[,,] matrix60 = Matrix3D(sizeX, sizeY, sizeZ, fillarray);
                    PrintMatrix3D(matrix60);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                }
                break;

            default: Console.WriteLine("Такой задачи не существует"); break;
        }
    }
}