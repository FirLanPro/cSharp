// ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int [,,] ArrayRandom(int[,,] array)
{
    int [] paddingLength = new int [array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  number;
    for (int i = 0; i < paddingLength.GetLength(0); i++)
    {
        paddingLength [i] = new Random().Next(10, 100);
        number = paddingLength [i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (paddingLength [i] == paddingLength [j])
                {
                    paddingLength [i] = new Random().Next(10, 100);
                    j = 0;
                    number = paddingLength [i];
                }
                number = paddingLength [i];
            }
        }
    }
    int count = 0; 
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = paddingLength [count];
                count++;
            }
        }
    }
    return array;
}

void PrintArray(int [,,] array)
{
        for (int k = 0; k < array.GetLength(2); k++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
            
                Console.Write($"{array[i,j,k]} ;  ");
                Console.Write($"индексы({i},{j},{k})|  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
}

void Output ()
{
    int x=Input("количество строк x: ");
    int y=Input("количество столбцов y: ");
    int z=Input("количество z: ");
    int [,,] array = new int [x,y,z];
    ArrayRandom(array);
    PrintArray(array);
}
Output ();
