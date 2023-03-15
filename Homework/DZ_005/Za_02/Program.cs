// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


void ArrayRandom (int [] NumberArr)
{
    int size=NumberArr.Length;
    for (int i=0; i<size; i++)
    {
        NumberArr [i]= new Random().Next(1,20);
        Console.Write(NumberArr[i] +" ");
    }
}

int EvenNumb (int [] NumberArr)
{
    int n=0;
    int size=NumberArr.Length;
    for (int i=0; i<size; i++)
    {
        if ( i%2!=0)
        {
            n=n+NumberArr[i];
        }
    }
    return n;
}

int [] array =new int [8];
ArrayRandom (array);
EvenNumb (array);
Console.WriteLine($"сумма элементов на нечётных позициях = "+ EvenNumb (array));