// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
int [,] ArrayRando( int [,]mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(0, 10);
        }
    }
    return mas;
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
void PrintArra( int [,]mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i,j]} ;  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m=Input("количество строк: ");
int n=Input("количество столбцов: ");
int [,] array = new int [m,n];
int k=Input("количество строк: ");
int l=Input("количество столбцов: ");
int [,] mas = new int [k,l];
ArrayRandom(array);
PrintArray(array);
ArrayRando(mas);
PrintArra(mas);