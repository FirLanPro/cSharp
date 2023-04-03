// массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string ArrayRandom (ref double [] array)
{
    int size = array.Length;
    string resultArr = String.Empty;
    for (int i=0; i<size; i++)
    {
        array [i] = new Random().NextDouble() + new Random().Next(-100,999);
        resultArr = resultArr + array[i] + " ";
    }
    return resultArr;
}

double MaxMin (double [] arrayString)
{
    double max = 0;
    double min = arrayString[0];
    int size = arrayString.Length;
    for (int i=0; i<size; i++)
    {
        if (arrayString[i] > max)
        {
            max = arrayString[i];
        }
        if (arrayString[i] < min)
        {
           min = arrayString[i];
        }
    }
    return max-min;
}

int length = Input("введите количество элементов в массиве: ");
double [] array =new double [length];
Console.Write($"массив: [ " + ArrayRandom(ref array) + "]");
Console.WriteLine();
Console.WriteLine("разница между максимальным и минамальным элементом массива =  " + MaxMin (array) );