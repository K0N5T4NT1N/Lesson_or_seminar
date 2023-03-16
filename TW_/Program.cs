using System;
/*
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

#nullable disable
System.Console.Write("Enter number A :");
int numA = int.Parse(Console.ReadLine());

if (numA < 1)
{
    System.Console.WriteLine("Число меньше 1");
}
else
{
    int result = GetSum(numA);
    System.Console.WriteLine($"sum =  {result}");
    System.Console.WriteLine($"sum =  {GetSum(numA)}");
}


int GetSum(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}

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
*/

// ========================= ВИКТОРИНА =========================
# nullable disable

#pragma warning restore format
string[,] array =
{
    {"Какие из перечисленных ниже программ являются антивирусными?", "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
    {"Какого типа графики не существует?", "Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
    {"Когда появился термин «информационные технологии» в современном значении?", "В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
    {"В каком году компанией IBM был выпущен первый в истории жесткий диск?", "В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
    {"Какая поисковая система была самой популярной в 2011 году?", "Yahoo!", "Google", "Bing", "Yandex", "Google"},
    {"Страна лидер по количеству суперкомпьютеров?", "Китай", "США", "Япония", "Россия", "Китай"},
    {"Какого Интернет-браузера не существует?", "MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
    {"Какие из клавиш клавиатуры относятся к группе функциональных?", "F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
    {"Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?", "200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"},
};

int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    System.Console.WriteLine(array[i, 0]);
    System.Console.WriteLine();
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        System.Console.WriteLine($"{j}) {array[i, j]};");

    }
    int answer = EnterAnswer("Введите ответ: ");
    if (Comparesment(answer, i)) count++;
    System.Console.WriteLine();
    System.Console.WriteLine();

}

System.Console.WriteLine($"Количество правильных ответов = {count}");


int EnterAnswer(string text)
{
    Console.Write($"{text}: ");
    int result;
    while (true)
    {
        string enterNumber = Console.ReadLine();
        if (int.TryParse(enterNumber, out result) && result <= 4 && result > 0)
            return result;
        else
            System.Console.WriteLine($"Error. {text}");
        return 0;
    }
}

bool Comparesment(int value, int index)
{
    return array[index, value] == array[index, array.GetLength(1) - 1];
}

string[] questionsArray = {"Сколько зубов у взрослого человека (без зубов мудрости)?" + "\r\n"+
"1) 28 2) 32  3) 26 4) 20",
                    "Какого Интернет-браузера не существует?" + "\r\n"+
"1) Opera 2) Google Chrome 3) Internet Explorer 4) MS PowerPoint",
                    "Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП? " + "\r\n"+
"200 МБит/с, 1 МБит/с, 100 МБит/с, 10 МБит/с",
                    "Какая поисковая система была самой популярной в 2011 году?" + "\r\n"+
" Yahoo!, Google, Bing, Yandex"
};
var clear = Console.Clear;

var questions = new Dictionary<string, int>()
{
    { questionsArray[0],1 },//"28"},

    {  questionsArray[1],4},//"MS PowerPoint"},

    {  questionsArray[2],3},//"100 МБит/с"},

    {questionsArray[3],2} //"Google"}

};

int countCorrect = 0; int countIncorrect = 0;

for (int i = 0; i < questionsArray.Length; i++)
{
    AsKQuest(questionsArray[i]);
}

if (countCorrect == questionsArray.Length)
    Console.WriteLine($"Поздравляем вы ответили правильно на вопросы ");

else if ((countIncorrect == questionsArray.Length))
    Console.WriteLine($"Поздравляем вы бездарь ");

else if (countCorrect > countIncorrect)
{ Console.WriteLine($"Поздравляем вы ответили правильно на большее кол-во вопросов "); CountCorrectAnswer(); }

else if (countCorrect < countIncorrect)
{ Console.WriteLine($"К сожалению вы ответили правильно на меньшее кол-во вопросов "); CountCorrectAnswer(); }

int ansver;
void AsKQuest(string AskNow)
{

    while (true)
    {
        ansver = AskQuestion(AskNow);
        if (ansver == 1 || ansver == 2 || ansver == 3 || ansver == 4)
        {
            CheckCorrect(AskNow, ansver); clear(); return;
        }
        else if (ansver == 000) return;
        else { Console.WriteLine("Неверное значение"); break; }
    }

}

int AskQuestion(string Ask)
{
    System.Console.WriteLine(Ask);
    ansver = int.Parse(Console.ReadLine());
    return ansver;
}

void CheckCorrect(string Ask, int ansver)
{
    if (questions[Ask] == ansver) countCorrect++;
    else countIncorrect++;
}

void CountCorrectAnswer()
{
    System.Console.Write($" правильных ответов {countCorrect}");
    System.Console.Write($" неправильных ответов {countIncorrect}");
}