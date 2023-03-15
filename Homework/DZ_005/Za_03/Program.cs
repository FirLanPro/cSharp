// массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
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
        array [i]= new Random().Next(-100,999);
        resultArr = resultArr + array[i] + " ";
    }
    return resultArr;
}

int MaxMin (int [] arrayString)
{
    int max=0;
    int min = arrayString[0];
    int size=arrayString.Length;
    for (int i=0; i<size; i++)
    {
        if (arrayString[i]>max)
        {
            max=arrayString[i];
        }
        if (arrayString[i]<min)
        {
           min=arrayString[i];
        }
    }
    return max-min;
}

int length = Input("введите количество элементов в массиве: ");
int [] array =new int [length];
Console.Write($"массив: [ " + ArrayRandom(array) + "]");
Console.WriteLine();
Console.WriteLine("разница между максимальным и минамальным элементом массива =  " + MaxMin (array) );