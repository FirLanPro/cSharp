// Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] array = new int [4,4];

int [,] ArrayRandom(int[,] array)
{
    int n=1;
    
    for (int i = 0; i < array.GetLength(0); i++) // укоротить !
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =n;
            n=n+1;
        }
        for (i = 1; i < array.GetLength(0); i++)
        {
            int j=array.GetLength(1)-1;
            array[i, j] =n;
            n=n+1;
        }
    }
    for (int j=array.GetLength(1)-2; j>=0;j--)
    {
        int i=array.GetLength(0)-1;
        array[i, j] =n;
        n=n+1;
    }
    for (int i=array.GetLength(0)-2; i>0; i--)
    {
        int j=0;
        array[i, j] =n;
        n=n+1;
    }
    for (int i = 1; i < array.GetLength(0)-2; i++)
    {
         for (int j=1; j<array.GetLength(1)-1; j++)
        {
            array[i, j] =n;
            n=n+1;
        }
    }
    for (int j=array.GetLength(1)-2;j>0;j-- )
    {
        int i=2;
        array[i, j] =n;
        n=n+1;

    }
    return array;
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            {
            Console.Write($" {array[i,j]}     ;  ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

ArrayRandom(array);
PrintArray(array);
