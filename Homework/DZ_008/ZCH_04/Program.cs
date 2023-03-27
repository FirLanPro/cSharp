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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
             array[i, j, k] = new Random().Next(10,100); //не повторение чисел?
             
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
