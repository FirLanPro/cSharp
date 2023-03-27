// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] ArrayRandomOne(int[,] arrOne)
{
    for (int i = 0; i < arrOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrOne.GetLength(1); j++)
        {
            arrOne[i, j] = new Random().Next(1, 5);
        }
    }
    return arrOne;
}
int [,] ArrayRandomTwo( int [,]arrTwo)
{
    for (int i = 0; i < arrTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrTwo.GetLength(1); j++)
        {
            arrTwo[i, j] = new Random().Next(1, 5);
        }
    }
    return arrTwo;
}
int [,] ProductOfTwo( int [,]arrTwo, int [,]arrOne, int [,]oneTwo)

{
   
    for (int i = 0; i < arrOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrTwo.GetLength(1); j++)
        {
            for (int k = 0;k < arrTwo.GetLength(0);k++ )
            { 
            oneTwo[i, j]= arrOne[i,k]*arrTwo[k,j]+ oneTwo[i,j]; // ??ik kj || kj ik правило умножения см.
            Console.WriteLine(oneTwo[i,j]);
            }
        }
    }
    return oneTwo;
}
void PrintOneArray(int [,] arrOne)
{
    for (int i = 0; i < arrOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrOne.GetLength(1); j++)
        {
            Console.Write($"{arrOne[i,j]} ;  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintTwoArray( int [,]arrTwo)
{
    for (int i = 0; i < arrTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrTwo.GetLength(1); j++)
        {
            Console.Write($"{arrTwo[i,j]} ;  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintProductOfTwo( int [,]oneTwo)
{
    for (int i = 0; i < oneTwo.GetLength(0); i++)
    {
        for (int j = 0; j < oneTwo.GetLength(1); j++)
        {
            Console.Write($"{oneTwo[i,j]}    ;  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void Output ()
{
    int m=Input("количество строк первой матрицы: ");
int n=Input("количество столбцов первой матрицы: ");
int [,] arrOne = new int [m,n];
int s=Input("количество строк второй матрицы: ");
int l=Input("количество столбцов второй матрицы: ");
int [,] arrTwo = new int [s,l];

int [,] oneTwo = new int [arrOne.GetLength(0),arrTwo.GetLength(1)];
    if (arrOne.GetLength(1) != arrTwo.GetLength(0))
    {
        Console.WriteLine($"Матрицы не перемножить");
    }
    
    ArrayRandomOne(arrOne);
PrintOneArray(arrOne);
ArrayRandomTwo(arrTwo);
PrintTwoArray(arrTwo);
ProductOfTwo(arrOne,arrTwo,oneTwo);
PrintProductOfTwo(oneTwo);
}
Output();