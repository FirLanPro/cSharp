// Равнобедренный треугольник в двумернов массиве. Построение относительно основания.

int [,] FillArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}
int [,] FillArray2(int[,] array)
{
    int k=0;
    int len = array.GetLength(1) ;
    for (int i = array.GetLength(0)-1; i >= 0; i--)
    {
        for (int j = k; j < len; j++)
        {
            array[i, j] = 1;
        }
        k=k+1;
        len=len-1;

    }
    return array;
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] array = new int [6,11];
FillArray(array);
PrintArray(array);
FillArray2(array);
PrintArray(array);