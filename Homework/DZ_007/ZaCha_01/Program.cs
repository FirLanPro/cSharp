// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] ArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() + new Random().Next(-100,999);
        }
        
    }
    return array;
}

void PrintArray(double[,] array)
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

void InputOutput()
{
    int m=Input("количество строк: ");
    int n=Input("количество столбцов: ");
    double [,] array = new double [m,n];
    Console.WriteLine();
    ArrayRandom(array);
    PrintArray(array);
}

InputOutput();