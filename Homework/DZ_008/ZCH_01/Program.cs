// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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

void Descending (int [,]arr)
{ 
    for (int i=0; i<arr.GetLength(0); i++)
    { 
        for (int j = 0; j < arr.GetLength(0)-1; j++)
        {
            int indexMinInRow=j;
            for (int k=j+1; k<arr.GetLength(0); k++)
            {
                if (arr[i,k]>arr[i,indexMinInRow])
                {
                    indexMinInRow=k;
                }
            }
            int temporaryStorage=arr[i,j];
            arr[i,j]=arr[i,indexMinInRow];
            arr[i,indexMinInRow]=temporaryStorage;
        }
    }      
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

void InputOutput()
{
    int m=Input("количество строк: ");
    int n=Input("количество столбцов: ");
    int [,] array = new int [m,n];
    Console.WriteLine();
    ArrayRandom(array);
    PrintArray(array);
    Descending(array);
    PrintArray(array);
}

InputOutput();