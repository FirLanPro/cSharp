// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool Position (int [,] arr, int m, int n)
{
    for (int i=0; i< arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            if (i==m && j==n )
            {
                return true;
            }
        }
    }
   return false;
}

string InputElement ( int [,] arr, int m, int n, bool position )
{
    if (position==true) 
    {
        return " значение элемента = " + arr[m,n];
    }
    return "";
}

void NoElement(int m, int n)
{
    if (m > 9 || n > 9)
    {
        Console.WriteLine("такого элемента нет");
    }
}

void InputOutput()
{
    int [,] array = new int [ 9, 9 ];
    int m = Input("строка: ");
    int n = Input("столбец: ");
    ArrayRandom(array);
    PrintArray(array);
    bool pos =Position (array, m, n);
    Console.WriteLine(InputElement(array, m, n, pos));
    NoElement(m, n);
}

InputOutput();