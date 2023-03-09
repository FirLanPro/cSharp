// Задача 19 Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void NN (int N)
{
if (N>99999 || N<9999)
    {
    Console.WriteLine ("не 5 цифр. перезапустите, введите пятизначное число");
    }
}

int Polindrom (int N)
{
    if (N<99999 && N>9999){
    int m=N%10;
    int x=N/10000;
   
    if (m==x && N>9999 ) { 
        N=N%10000;
        N=N/10;
        m=N%10;
        x=N/100;
        }
             
    if (m==x && N>99)  {
         N=N%100;
         N=N/10;
         Console.WriteLine("палиндром ");
        } 
    else {
        Console.WriteLine("не палиндром") ; 
         } 
     }
return N;
}
Console.Write ("введите пятизначное число : ");
int N = Convert.ToInt32(Console.ReadLine());
NN (N);
Polindrom( N);        