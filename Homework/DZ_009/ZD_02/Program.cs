// Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N включительно.

int Input (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int AmountInInterval(int m, int n)
{
    if ( m>0 && m<=n)  return m+ AmountInInterval(m+1,n) ;
    else if ( m<=0) return AmountInInterval(m+1,n); // если m не натуральный элемент проверяем следующее элемент
    else return 0;
}
void InputOutput ()
{
    int M = Input("число от: ");
    int N = Input("число до: ");
    if ( N>0 ) // если N больше нуля, т.е. является натуральным, рекурсия выводит сумму до N. или само число N, при N=1
    {
        Console.WriteLine (AmountInInterval(M,N));
    }
    else Console.WriteLine ("натуральных элементов нет, промежуток полностью из ненатуральных чисел");
}
InputOutput ();