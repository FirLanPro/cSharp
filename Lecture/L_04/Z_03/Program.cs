// вывод значений от 1 до 18.Факториал.
double Factorial(int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}
for (int i=1;i<19;i++)
{
Console.WriteLine($"{i} ={Factorial(i)}");
}
