//
#nullable disable
Console.Clear();
Console.WriteLine("Задача 19: определение является ли число полиндромом"); //альтернитивное решение
Console.WriteLine("Введите целое число:");
long NumPoly;
if (!long.TryParse(Console.ReadLine(), out NumPoly))
{
    Console.WriteLine("Некорректный ввод");
    return;
}
long NumPolyModul = Math.Abs(NumPoly);
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
    Console.WriteLine($"{NumPoly} -> да, полиндром");
}
    else
{
    Console.WriteLine($"{NumPoly} -> не полиндром");
}
Console.WriteLine("Для продолжения нажмите любую клавишу..." );
Console.ReadKey();
