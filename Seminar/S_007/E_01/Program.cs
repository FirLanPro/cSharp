//  Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int [,] FillArray(int[,] array)
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
int [,] Metod3 (int [,] arr)
{
    
    for (int m=1; m < arr.GetLength(0); m++)
    {
        
        for (int n=1; n < arr.GetLength(1); n++)
        {
            if (m%2==0 && n%2==0 && arr[m,n]!=0)
            {
           
                Console.Write($"элемент = {arr[m,n]} , индексы = {m}, {n}");
                arr[m,n]=arr[m,n]*arr[m,n];
                Console.WriteLine($", в квадрате = {arr[m,n]} ");
            }
        }
    }
    Console.WriteLine();
    return arr;
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

void PrintArray2(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n< arr.GetLength(1); n++)
        {
            Console.Write($"{arr[m,n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] array = new int [9,9];
FillArray(array);
PrintArray(array);
Metod3(array);
PrintArray2(array);