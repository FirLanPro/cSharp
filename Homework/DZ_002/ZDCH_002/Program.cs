// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (3-я цифра с начала числа).

int e=0;
int a=0;
int Bnum (int N){
    if  (N /1000 != 0)
  {
  
    while (N > 999)
     {
    N= N/ 10;
      }
     a=N%10;
    Console.Write("третья цифра числа: ");
  }
return a;
}

int Number ( int N)
{
   if  (N /100 != 0 && N /1000 == 0)
   {
      e = N % 10;
      Console.Write("третья цифра числа: ");
   }

    return e;
}

void Num ( int N )
{
  if (N /100 == 0)
  {
     Console.WriteLine ("3-ей цифры нет ");
   }
  return ;
}

Console.WriteLine("Введите  число: ");
int N = Convert.ToInt32(Console.ReadLine());
Num (N);

int Bnu =Bnum(N);
System.Console.WriteLine(Bnu);


int res = Number (N);
System.Console.WriteLine(res);
