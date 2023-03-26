// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void Summa (int [,] arr)
{
    int str=0;
    int k=0;
    for (int i=0; i< arr.GetLength(0); i++)
    {
        int sum=0;
        for (int j=0; j < arr.GetLength(1); j++)
        {
           sum= sum+arr[i,j];
        }
        if (i==0)
        {
            k=sum;
        }
        else if (sum<k)
        {
            k=sum;
            str = i+1;
        }
        Console.WriteLine ($"Сумма в строке {i+1} = {sum}"); 
        
    }
    Console.WriteLine();
    Console.WriteLine ($"Наименьшая сумма элементов в строке : {str}"); 
}

bool Output (int [,]array, int m, int n)
{
   if (m!=n) 
   {
        Console.WriteLine();
        ArrayRandom(array);
        PrintArray(array);
        Summa(array);
        return true;
   }
   else 
   {
    Console.WriteLine($"не прямоугольный двумерный массив");
    return false;
   }
}
int m=Input("количество строк: ");
int n=Input("количество столбцов: ");
int [,] array = new int [m,n];
Output(array,m,n);