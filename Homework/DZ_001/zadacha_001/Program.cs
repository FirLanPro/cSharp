// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}


Console.Write("БОЛЬШЕЕ= ");
Console.WriteLine(max);
Console.Write("МЕНЬШЕЕ= ");
Console.WriteLine(min);

