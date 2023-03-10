//  цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int vvod (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int round (int A, int B)
{
    int C=1;
    for (int i=0;i<B; i++ )
    {
        C=C*A;
    }
    return C;
}
int A = vvod("Введите число A: ");
int B = vvod("Введите число B: ");
int res = round (A,B);
Console.WriteLine ($"Число {A} в степени {B} = {res}");