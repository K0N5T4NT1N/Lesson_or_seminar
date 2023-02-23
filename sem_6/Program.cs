/*
void FindValueInMatrix(int[,] matrix, int desired)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if(matrix[i, l] == desired)
            {
                Console.WriteLine($"{desired} -> число найдено!");
                break;
            }  
            else
            {
                Console.WriteLine($"{desired} -> такого числа в массиве нет");
            }
                            
        }
        
    }
    
}
*/



// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// 

int numRows = SetNumber("Rows");

int numColumns = SetNumber("Columns");

int numMaxValue = SetNumber("Max Value");

int numMinValue = SetNumber("Min Value");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[,] GetMatrix(int rows, int columns, int min, int max)
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

int[,] GetMatrix2(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = i + l;
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
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

// задайте двумерный массив размера m на n,
// каждый элемент находитсяао формуле A=m+n.

numRows = SetNumber("Rows");

numColumns = SetNumber("Columns");

numMaxValue = SetNumber("Max Value");

numMinValue = SetNumber("Min Value");

matrix = GetMatrix2(numRows, numColumns, numMinValue, numMaxValue); // меод getmatrix2 добавлен
Print(matrix);
CheckMatrix(matrix);
Print(matrix);

//задача 49

void CheckMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (isEven(i,l))
            {
                matrix[i,l] *= matrix[i,l];
            }
        }
        
    }
}

bool isEven(int i, int l)
{
    return i%2 == 0 && l%2 == 0;
}


//задача 50 сложение значений главной диагонали (0,0) (1,1) (2,2)

numRows = SetNumber("Rows");

numColumns = SetNumber("Columns");

numMaxValue = SetNumber("Max Value");

numMinValue = SetNumber("Min Value");

matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue); 
SumNumMatrix(matrix);
Print(matrix);

bool MajorDiag(int i, int l)
{
    return i == l;
}

int SumNumMatrix(int[,] matrix)
{
    int Sum =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (MajorDiag(i,l))
            {
                Sum += matrix[i,l];
            }
        }
    }
    return Sum;
}

// заполнение спиралью по аналогии с лекцией 4

// заполнение фибоначи:

double FibonacciBad(int n) // плохой вариант
{
	if(n == 1 || n == 2) return 1;
	else return FibonacciBad(n-1) + FibonacciBad(n-2);
}

double FibonacciR(double[] f, int n)
{
	if(n == 1 || n == 2) 
    {
        return f[n-1] = 1;
    }
	else
    {
        if(f[n-2]!=0)
        {
            if(f[n-1]!=0)
                return f[n-1] = f[n-2] + f[n-3];
            else
                return  f[n-1] = FibonacciR(f, n-1) + f[n-3];
        }
        else
            return f[n-1] = FibonacciR(f, n-1) + FibonacciR(f, n-2);
    }
}

double FibonacciGood(int n) // хороший вариант
{
    
    double[] f = new double[n];
    return FibonacciR(f, n);
}


int countTests = 40;


DateTime saveTime;

Console.WriteLine($"Цикл for: ");
saveTime = DateTime.Now;
int fibonacci1 = 1;
int fibonacci2 = 1;
for (int i = 1; i <= countTests; i++)
{
	Console.WriteLine($"f({i}) = {fibonacci2}");
	int temporary = fibonacci2;
	fibonacci2 += fibonacci1;
	fibonacci1 = temporary; 
}
Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");


Console.WriteLine($"FibonacciBad: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{

	Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
}
Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");


Console.WriteLine($"FibonacciGood: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{

	Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
}
Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");
