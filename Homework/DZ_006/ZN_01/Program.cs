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
        Console.Write($"введите {i+1}-ое число : ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i]=number;
    }
    Console.WriteLine();
}

int AboveZero (ref int [] array)
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
int [] array =new int[length];
Console.WriteLine();
ArrayInput(array);
Console.WriteLine($"количество чисел больше нуля : {AboveZero(ref array)}");    