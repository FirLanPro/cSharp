﻿// метод(-ы), который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Input (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

string Cube (int n)
{
    for(int i=1;i<=n;i++)
    {
        Console.WriteLine($"число: {i}  | число в кубе: {i*i*i}");
        Console.WriteLine ($"-------------------------------");
    }
    Console.WriteLine();
    return "значения";
}

int n = Input("Введите число до которого вычисляется куб: ");
Cube (n);