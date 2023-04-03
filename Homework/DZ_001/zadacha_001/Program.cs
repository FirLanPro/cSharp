// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число 1: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int max = Convert.ToInt32(Console.ReadLine());
int m = 0;
if (min > max)
{
    m = min;
    max = min;
    min = m;
}
Console.Write("БОЛЬШЕЕ= ");
Console.WriteLine(max);
Console.Write("МЕНЬШЕЕ= ");
Console.WriteLine(min);

