// программу, которая задаёт массив из 8 элементов и выводит их на экран.


void ArrayRandom (int [] NumberArr)
{
    int size=NumberArr.Length;
    for (int i=0; i<size; i++)
    {
        NumberArr [i]= new Random().Next(1,50);
        Console.Write(cccc[i] +", ");
    }
}
int [] array =new int [8];
ArrayRandom (array);
