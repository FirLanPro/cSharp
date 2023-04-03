// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Если сумма в строках совпадает, 
// номер стороки с наименьшей суммой присваивается строке с меньшим номером.
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

void SummaElementInStr (int [,] arr)
{
    int str = 1;
    int k = 0;
    for (int i=0; i< arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j=0; j < arr.GetLength(1); j++)
        {
           sum= sum+arr[i,j];
        }
        if (i == 0)
        {
            k = sum;
        }
        else if (sum<k)
        {
            k = sum;
            str = i+1;
        }
        Console.WriteLine ($"Сумма в строке {i+1} = {sum}"); 
        
    }
    Console.WriteLine();
    Console.WriteLine ($"Наименьшая сумма элементов в строке : {str}"); 
}

void Output (int [,]array, int m, int n)
{
   if (m!=n && m>=2 && n>=2) 
   {
        Console.WriteLine();
        ArrayRandom(array);
        PrintArray(array);
        SummaElementInStr(array);
   }
   else 
   {
    Console.WriteLine($"не прямоугольный двумерный массив для нахождения в строке суммы");
   }
}
int m = Input("количество строк: ");
int n = Input("количество столбцов: ");
int [,] array = new int [m,n];
Output(array,m,n);