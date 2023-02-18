//методы начало
int InputUser(string message)
{
    Console.Write(message);
    string ReadVoid = Console.ReadLine();
    int result = int.Parse(ReadVoid);
    return result;    
}

int InputUserValidationVoid(string message)
{
    Console.Write(message);
    string ReadVoid = Console.ReadLine();
    int result;
    if (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        Console.WriteLine("Некорректный ввод"); 
        return;
    }
}   

int[] FillingManualArray(int length, int Value)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int[] GenerateManualArray(int length, int Value)
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

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. \n Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, \n заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
        Console.WriteLine("Задача 44: Выведите первые N чисел Фибоначчи. \n Первые два числа Фибоначчи: 0 и 1");
        Console.WriteLine("Для выхода введите: 0");

        int numTask = InputUser("Введите номер задачи: ");

        switch (numTask)
        {
            case 0: return; break;

            case 41:
                Console.Clear();
                int elementsCount = InputUserValidationVoid("Какое количество чисел проверить? ");
                int[] array41 = new int[elementsCount];
                Console.WriteLine(String.Join(" ", array41));
                Console.WriteLine($"Количество чисел больше нуля -> {GetEvenCount(startArray)}");
                break;
            case 43:
                Console.Clear();
                startArray = GetArray(6, 0, 999);
                Console.WriteLine(String.Join(" ", startArray));
                Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");
                break;

            case 44:
                Console.Write("Введите элементы массива через пробел: ");
                string elements = Console.ReadLine();
                int[] baseArray = GetArrayFromString(elements);
                Console.WriteLine(String.Join(" ", ResultArray(baseArray)));
                break;
            
            default: Console.WriteLine("Такой задачи не существует"); break;
        }
    }
}