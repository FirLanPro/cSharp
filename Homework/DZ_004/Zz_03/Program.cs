// программу, которая задаёт массив из 8 элементов и выводит их на экран.


void H (int [] cccc)
{
    int size=cccc.Length;
    for (int i=0; i<size; i++)
    {
        cccc [i]= new Random().Next(1,50);
        Console.Write(cccc[i] +", ");
    }
}
int [] array =new int [8];
H (array);
