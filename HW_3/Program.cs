
/*
Задача 19: Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

#nullable disable
Console.Clear();
Console.WriteLine("Задача 19: определение является ли число полиндромом"); //решение по ТЗ
int NumPoly;
while (true)
{
Console.WriteLine("Введите пятизначное, положительное целое число:");
NumPoly = int.Parse(Console.ReadLine());
int bitDepthBegin = 10000;
int bitDepthEnd = 99999;
if (NumPoly >=bitDepthBegin && NumPoly <= bitDepthEnd)
    {
    break;
    }
}
if (NumPoly % 10 == NumPoly / 10000 && NumPoly % 100 / 10 == NumPoly / 1000 % 10) // сравниваем первый с последним знаком и второй с предпоследним
{
    Console.WriteLine($"{NumPoly} -> да, полиндром");
}
else
{
    Console.WriteLine($"{NumPoly} -> не полиндром");
}
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

Console.Clear();
Console.WriteLine("Задача 19: определение является ли число полиндромом"); //альтернитивное решение
Console.WriteLine("Введите целое число:");
long NumPoly2;
if (!long.TryParse(Console.ReadLine(), out NumPoly2))
{
    Console.WriteLine("Некорректный ввод");
    return;
}
long NumPolyModul = Math.Abs(NumPoly2);
int Depth = -1;
long ValueTemp = NumPolyModul;
long ValueBegin = 0;
long ValueEnd = 0;
long ValueInvert = 0;

for (; ValueTemp > 0; Depth++)
{
    ValueTemp /= 10;
}
ValueTemp = NumPolyModul; 
// Console.WriteLine(Depth);
// Console.ReadKey();
ValueBegin = (long)Math.Pow(10, Depth);
// Console.WriteLine(ValueBegin);
// Console.ReadKey();
while (Depth >= 0)
{
    ValueEnd = ValueTemp % 10;
    ValueTemp /= 10;
    ValueEnd *= ValueBegin;
    ValueBegin /= 10;
    ValueInvert = ValueInvert + ValueEnd;
    Depth--;
}
// Console.WriteLine(ValueInvert);
// Console.ReadKey();
    if (ValueInvert == NumPolyModul)
{
    Console.WriteLine($"{NumPoly2} -> да, полиндром");
}
    else
{
    Console.WriteLine($"{NumPoly2} -> не полиндром");
}
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();

/*
Задача 21: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

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

Console.Write($"{NumN} -> ");
while(Cube <= NumN)
{
    System.Console.Write(Math.Pow(Cube, 3) + ", ");
    Cube++;
}

Console.ReadKey();