// Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int AmountInInterval(int m, int n)
{
    int result = 0;
    for(int i = m; i <n; i++) result +=i; //m==n ?
    return result;
}
int M = Input("число от: ");
int N = Input("число до: ");
Console.WriteLine (AmountInInterval(M,N));