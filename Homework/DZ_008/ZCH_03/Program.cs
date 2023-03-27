// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// умножение матрицы В на А.
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
            oneTwo[i, j]= arrOne[i,k]*arrTwo[k,j]+ oneTwo[i,j]; 
            
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

void InputOutput ()
{
    int s=Input("количество строк матрицы В: ");
    int l=Input("количество столбцов матрицы В: ");
    int [,] arrTwo = new int [s,l];
    int m=Input("количество строк матрицы А : ");
    int n=Input("количество столбцов первой матрицы А: ");
    int [,] arrOne = new int [m,n];

    int [,] oneTwo = new int [arrOne.GetLength(0),arrTwo.GetLength(1)];
    if (arrOne.GetLength(1) != arrTwo.GetLength(0))
    {
        Console.WriteLine($"Матрицы не перемножить");
    }
    Console.WriteLine($"Матрица В:");
    ArrayRandomTwo(arrTwo);
    PrintTwoArray(arrTwo);
    Console.WriteLine($"Матрица A:");
    ArrayRandomOne(arrOne);
    PrintOneArray(arrOne);
    ProductOfTwo(arrOne,arrTwo,oneTwo);
    PrintProductOfTwo(oneTwo);
}
InputOutput();
