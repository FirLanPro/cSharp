// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string ArrayRandom (int [] array)
{
    int size =array.Length;
    string resultArr = String.Empty;
    for (int i=0; i<size; i++)
    {
        array [i]= new Random().Next(100,999);
        resultArr = resultArr +array[i] + " ";
    }
    return resultArr;
}

int EvenNumb (int [] array)
{
    int j=0;
    int size=array.Length;
    for (int i=0; i<size; i++ )
    {
        if ( array[i]%2==0 )
        {
            j=j+1;
        }
    }
    return j;
}

int length = Input ("введите количество элементов массива: ");
int [] array = new int [length];
Console.Write($"массив: [ " + ArrayRandom(array) + "]");
Console.WriteLine();
Console.WriteLine($"количество четных чисел в массиве : "+ EvenNumb (array));