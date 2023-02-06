
/*
Задача 19: Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

/*
Задача 21: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

#nullable disable
Console.Clear();
Console.WriteLine("Задача 21: определение расстояния между точками в 3D");
Console.WriteLine("Введите координаты первой точки:");
Console.WriteLine("Введите значение X1: ");
double numX1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение Y1: ");
double numY1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение Z1: ");
double numZ1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.WriteLine("Введите значение X2: ");
double numX2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение Y2: ");
double numY2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение Z2: ");
double numZ2 = double.Parse(Console.ReadLine());

double numSQRT = Math.Sqrt(Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2)+Math.Pow((numZ1-numZ2),2));

Console.WriteLine($"Расстояние между точками -> {numSQRT}");
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

/*
Задача 23: Напишите программу, которая принимает на вход
число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
System.Console.WriteLine("Задача 23: таблица кубов от 1 до N");
System.Console.Write("Введите число N: ");
int NumN = int.Parse(Console.ReadLine()); // или лучше через дабл??

int Cube = 1;

while(Cube <= NumN)
{
    System.Console.Write(Math.Pow(Cube, 3) + " ");
    Cube++;
}
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();