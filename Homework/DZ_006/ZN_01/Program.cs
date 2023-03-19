// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void ArrayInput( int [] array)
{
    int size = array.Length;
    for (int i=0; i<size; i++)
    {
        Console.Write($"введите число {i+1} :");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i]=number;
    }
    Console.WriteLine();
}

int AboveZero (int [] array)
 {
    int moreZero=0;
    int size = array.Length;
    for (int i=0; i<size; i++)
    {
        if (array[i]>0)
        {
            moreZero=moreZero+1;
        }
    }
    return moreZero;
}

int length = Input("Количество чисел: ");
Console.WriteLine();
int [] array =new int[length];
ArrayInput(array);
Console.WriteLine($"больше нуля : {AboveZero(array)} числа");    