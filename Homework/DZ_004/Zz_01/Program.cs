//  цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// основание -A с четной степенью = A с темже значением степени.
// основание -A с нечетной степенью = -A с темже значением степени.
// основание A с отрицательной степенью = 1/A  темже значением степени.
// основание -A с отрицательной четной степенью = 1/A  темже значением степени.
// основание -A с отрицательной нечетной степенью = 1/-A  темже значением степени.

int vvod (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int round (int A, int B)
{
    int C=1;
    if (A!=0)
    {
        B=Math.Abs(B);
        for (int i=0;i<B; i++ )
        {
            C=C*A;
        }
        Console.WriteLine(C);
    }
    return C;
}

string negative (int B)
{
    if (B<0)
    {
        Console.Write($"1/"); 
    }
    return "";
}

bool zero(int A,int B)
{
    if (A==0)
    {
        Console.WriteLine($"основание A не может быть = 0");
        return true;
    }
        Console.Write ($"Число {A} в степени {B} = ");
        return false;
}

int A = vvod("Введите число A: ");
int B = vvod("Введите число B: ");
zero(A,B);
string res = negative (B);
Console.Write ($"{res}");
round (A,B);