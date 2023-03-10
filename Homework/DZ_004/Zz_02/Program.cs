// программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int round (int N)
{
    int X=0;
    while  ( N > 0 )
    {
        X=X+N%10;
        N=N/10;
    }
    return X;
}
int N = input("Введите число N: ");
int res = round (N);
Console.WriteLine($"сумма цифр в числе {N} = {res}");


