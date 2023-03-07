// Задача 19 Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write ("введите пятизначное число : ");
int N = Convert.ToInt32(Console.ReadLine());
int i;
 int M=0;
 int X=0;

string NN (int N)
{
if (N<99999 && N>9999)
    {
    return "5 цифр";
    }
    Console.WriteLine ("не 5 цифр");
return "hj";
}

int Polindrom (int N)
{
 
    for (i=2; i>0; i=i-1)
    {
        M = N%10;
        X = N/10000;
     
    }
    return N;
}


int res = Polindrom(N);
Console.WriteLine (res);

NN (N);



        