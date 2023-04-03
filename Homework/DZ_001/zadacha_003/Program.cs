// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2==0)
{
    Console.Write("четное число ");
    Console.WriteLine(a);
}
else 
{
    Console.Write("нечетное число ");
    Console.WriteLine(a); 
}

