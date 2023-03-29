// Напишите программу 
// вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int A(int m, int n)
{
    if (m==0) return n+1;
    else if(m>0 && n==0) return A(m-1,1); 
    else return A(m-1,A(m,n-1)); // при m=4,n=1 выводит значение, примерно, через 30 секунд.
}

void InputOutput ()
{
    int m=Input("Введите число: ");
    int n=Input("Введите число: ");
    if (m>=0 && n>=0)
    {
         Console.WriteLine($"{A(m, n)}");
    }
    else Console.WriteLine("по условию, два неотрицательных числа");
}
InputOutput ();
