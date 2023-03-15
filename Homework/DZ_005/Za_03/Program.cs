// массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
int input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void ArrayRandom (int [] NumberArr)
{
    int size=NumberArr.Length;
    for (int i=0; i<size; i++)
    {
        NumberArr [i]= new Random().Next(1,50);
        Console.Write(NumberArr[i] +", ");
    }
}

int MaxMin (int [] NumberArr)
{
    int max=0;
    int min = NumberArr[0];
     int size=NumberArr.Length;
    for (int i=0; i<size; i++)
    {
        if (NumberArr[i]>max)
        {
            max=NumberArr[i];
        }
        if (NumberArr[i]<min)
        {
           min=NumberArr[i];
        }
    }
    return max-min;
    
   
}
int A = input("введите количество элементов в массиве: ");
int [] array =new int [A];
ArrayRandom (array);
Console.WriteLine();
int res = MaxMin (array);
Console.WriteLine("разница между максимальным и минамальным элементом массива:  "+ res);
//int B = input("Введите число B: ");