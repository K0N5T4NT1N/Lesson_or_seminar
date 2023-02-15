/*
Задача 10: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine("Задача 10 определение второго числа");
Console.Write("Введите трехзначное положительное число: ");
int num;
if (!int.TryParse(Console.ReadLine(), out num))
{
  Console.WriteLine("Некорректный ввод");
  return;
}


int result = (num / 10) % 10;

if (num / 100 < 1 || num / 100 > 10) //проверка на трехзначное положительное число 
  Console.WriteLine("Число не является трехзначным");
else
  Console.WriteLine($"Ответ: {result}");
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.WriteLine("Задача 13 определение третьей цифры числа");
Console.Write("Введите число: ");
int Numbers;
if (!int.TryParse(Console.ReadLine(), out Numbers))
{
    Console.WriteLine("Некорректный ввод");
    return;
}

int Value = Math.Abs(Numbers);   // Проверка отрицательных чисел (можно было бы домножть на -1 при условии value < 0)

if (Value <= 99)
{
    Console.WriteLine("Число не является трехзначным");
    return;
}

while (Value > 999)
{
    if (Value > 999) Value /= 10;
}

Console.WriteLine($"Третья цифра в числе - {Value % 10}");
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("Задача 15 день недели: будни/выходной");
Console.WriteLine("Введите день недели: (пн: 1, вт: 2, ср: 3, чт: 4, пт: 5 сб: 6, вс: 7)");

int Day;
if (! int.TryParse(Console.ReadLine(), out Day))
{
  Console.WriteLine("Некорректный ввод");
  return;
}

if (Day < 0 || Day > 7)
{
  Console.WriteLine("Нет такого дня недели!");
  return;
}

if (Day == 6 || Day == 7)
Console.WriteLine("Выходной");
else
Console.WriteLine("Будний день");
