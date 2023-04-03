// Задайте значение N. 
// Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
string IntervalNumbers(int a, int b) 
{
    if (a >= b) return $"{a} " + IntervalNumbers(a-1, b);
    else return String.Empty;
}
void InputOutput ()
{
    int N = Input("Введите число: ");
    if (N > 0)
    {
    Console.WriteLine(IntervalNumbers(N, 1));
    }
    else Console.WriteLine("Не натуральное число. Любое натуральное число больше нуля");
}
InputOutput ();