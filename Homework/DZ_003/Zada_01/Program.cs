// Задача 19 Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write ("введите пятизначное число : ");
int N = Convert.ToInt32(Console.ReadLine());


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
{int m=N%10;
        int x=N/10000;
if (N<99999 && N>9999) 
{      
    if (m!=x && N>999)
        {
        Console.WriteLine("не полиндром");
        
        }
    else {
        int y=N/10000;
        N=N-y*10000;
        N=N/10;
        x=N/100;
        m=N%10;
        Console.WriteLine(N);
    }
    if (m!=x && N<99)
        {
        Console.WriteLine("не полиндром");
        }
    else {
        int y=N/100;
        N=N-y*100;
        N=N/10;
        
        Console.WriteLine(N);

    }

}
return N;
}
Polindrom(N);
NN (N);



        