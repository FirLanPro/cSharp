// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

void  Metod3 (int [,] arr, int m, int n)
{
    for (int i=0; i< arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            if (i==m && j==n )
            {
                Console.WriteLine($" индексы = {i}, {j}, элемент = {arr[i,j]} ");
                
            }
            
        }
    }
   
}

void InputOutput()
{
    int [,] array = new int [9,9];
    int m =Input("строка: ");
    int n =Input("столбец: ");
    FillArray(array);
    PrintArray(array);
    Metod3 (array,m,n);
   
    
}

InputOutput();





