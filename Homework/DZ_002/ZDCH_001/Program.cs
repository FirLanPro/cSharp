// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number ( int N)
{
   int e=0;
   if  (N /100 != 0 && N /1000 == 0)
   {
      e = N / 10%10;
      Console.Write("вторая цифра в числе: ");
      
   }   
return e;
}

void Num ( int N )
{
  if (N /100 == 0 || N /1000 != 0)
  {
     Console.WriteLine ("не 3 цифры ");
   }
  return ;
}

Console.WriteLine("Введите 3-х значное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Num (N);

int res= Number (N);
System.Console.WriteLine(res);