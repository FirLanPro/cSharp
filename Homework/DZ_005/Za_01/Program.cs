// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


void ArrayRandom (int [] NumberArr)
{
    int size=NumberArr.Length;
    for (int i=0; i<size; i++)
    {
        NumberArr [i]= new Random().Next(100,999);
        Console.Write(NumberArr[i] +" ");
    }
}

int EvenNumb (int [] NumberArr)
{
    int j=0;
    int size=NumberArr.Length;
    for (int i=0; i<size; i++ )
    {
        if ( NumberArr[i]%2==0 )
        {
            j=j+1;
        }
    }
    return j;
}
int [] array =new int [8];
ArrayRandom (array);
EvenNumb (array);
Console.WriteLine($"четных чисел в массиве :"+ EvenNumb (array));