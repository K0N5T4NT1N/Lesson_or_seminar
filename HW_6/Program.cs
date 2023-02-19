#nullable disable
//методы начало
int InputUser(string message)
{
    Console.Write(message);
    string ReadVoid = Console.ReadLine();
    int result = int.Parse(ReadVoid);
    return result;
}

/* допилить, как будет время.
int InputUserValidationVoid(string message)
{
    Console.Write(message);
    string ReadVoid = Console.ReadLine();
    int result = int.Parse(ReadVoid);
    if (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        Console.WriteLine("Некорректный ввод");
        return;
    }
    
}   
*/
/*
int[] FillingManualArray(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
*/

void OutputArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int CountIndexPositiv(int[] array)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void Fibonacci(int numberN)
{
    int temp = 0;
    int fibonacci1 = 1;
    int fibonacci2 = 1;
    if (numberN == 0)
    {
        Console.Write(temp);
    }
    if (numberN == 1)
    {
        Console.Write($"{temp} {fibonacci1}");
    }
    if (numberN == 2)
    {
        Console.Write($"{temp} {fibonacci1} {fibonacci2}");
    }
    else
    {
        Console.Write($"{temp} {fibonacci1} {fibonacci2}");
        for (var i = 2; i < numberN; i++)
        {
            temp = fibonacci1 + fibonacci2;
            fibonacci2 = fibonacci1;
            fibonacci1 = temp;
            Console.Write($" {fibonacci1}");
        }
    }
}



/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
Задача 44:выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5
--> 0 1 1 2 3
Если N = 3
--> 0 1 1
Если N = 7
--> 0 1 1 2 3 5 8
*/

Console.Clear();

HomeWork();

void HomeWork()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n");
        Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 \n");
        Console.WriteLine("Задача 44: Выведите первые N чисел Фибоначчи.Первые два числа Фибоначчи: 0 и 1 \n");
        Console.WriteLine("Для выхода введите: 0 \n");

        int numTask = InputUser("Введите номер задачи: ");

        switch (numTask)
        {
            case 0: return;

            case 41:
                Console.Clear();
                Console.Write("Какое количество чисел проверить? ");
                int elementsCount;
                if (!int.TryParse(Console.ReadLine(), out elementsCount) || elementsCount <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                    return;
                }
                int[] array41 = new int[elementsCount];
                for (var i = 0; i < elementsCount; i++)
                {
                    Console.Write($"\nВведите элемент массива с индексом {i}: ");
                    array41[i] = int.Parse(Console.ReadLine());
                }
                OutputArray(array41); Console.WriteLine($" Количество чисел больше нуля -> {CountIndexPositiv(array41)}");
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            case 43:
                Console.Clear();
                /*
                array43 = GetArray(6, 0, 999);
                OutputArray(array43); Console.Write($" -> {CountOddIndex(array)}");
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                */
                Console.ReadKey();
                break;

            case 44:
                int fibonacciN = InputUser("До какого числа показать ряд?: ");
                Fibonacci(fibonacciN); Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                break;

            default: Console.WriteLine("Такой задачи не существует"); break;
        }
    }
}