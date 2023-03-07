// Кубы чисел от 1 до N. вариант 2 
string Numbers (int N)
{
   string strok =String.Empty;
 int a = 1;
 while (a <= N)
    {
        int result=a*a*a;
        strok=strok+result + " ";
        a = a + 1;
    }
    return strok;
}
    Console.Write("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    string vivod = Numbers (N);
    System.Console.WriteLine(vivod);