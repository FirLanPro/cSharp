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
int [] array =new int [8];
ArrayRandom (array);

int EvenNumb (int [] NumberArr)
{int n=0;
 int size=NumberArr.Length;
for (int i=0; i<size; i++){
   if ( NumberArr[i]%2==0)
   {
    n=n+1;
   }
}
return n;
}
EvenNumb (array);
Console.WriteLine($"четных чисел:"+ EvenNumb (array));