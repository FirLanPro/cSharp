// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ;  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double Summa (int [,]array, int m)
{ 
    double sum = 0;
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        average = sum/m;
        sum = 0;
        Console.WriteLine($"среднее арифметическое столбца {j+1} = {average} ; ");
    }
    return average;
}

void InputOutput()
{
    int m = Input("количество строк: ");
    int n = Input("количество столбцов: ");
    int [,] array = new int [m,n];
    Console.WriteLine();
    ArrayRandom(array);
    PrintArray(array);
    Summa(array,m);
}

InputOutput();