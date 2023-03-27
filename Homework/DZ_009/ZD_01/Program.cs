﻿// Задайте значение N. 
// Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
string NumberRec(int a, int b) 
{
    if (a <=b) return $"{a} " + NumberRec(a+1, b);
    else return String.Empty;
}
void InputOutput ()
{
    int N=Input("Введите число: ");
    Console.WriteLine(NumberRec(1, N));
}
InputOutput ();