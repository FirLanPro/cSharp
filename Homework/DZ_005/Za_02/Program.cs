// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (нечетный индекс элемента).

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
        array [i]= new Random().Next(-1000,1000);
        resultArr = resultArr + array[i] + " ";
    }
    return resultArr;
}

int EvenNumb (int [] arrayString)
{
    int oddNumber = 0;
    int size = arrayString.Length;
    for (int i=0; i < size; i++)
    {
        if ( i % 2 !=0)
        {
            oddNumber = oddNumber + arrayString[i];
        }
    }
    return oddNumber;
}

int length = Input ("введите количество элементов массива: ");
int [] array = new int [length];
Console.Write($"массив: [ " + ArrayRandom(array) + "]");
Console.WriteLine();
Console.WriteLine($"сумма элементов на нечётных позициях = "+ EvenNumb (array));