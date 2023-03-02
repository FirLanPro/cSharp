int Number ( int N)
{
int e=0;

if  (N /100 != 0 && N /1000 == 0)
{
    e = N / 10%10;
 Console.Write("вторая цифра в числе: ");
}   
  else
   {
    e=N;
  Console.Write("не 3 цифры в числе: ");
    
     }
 
 return e;
}

Console.Write("Введите 3-х значное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int res= Number (N);
System.Console.WriteLine(res);





//if (N /100 != 0 && N /1000 == 0)
//{
 //   e = N / 10%10;
 //   Console.WriteLine(e);
//}   
 //  else
  // {
 //  Console.WriteLine("не 3 знака");
  // }