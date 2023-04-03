// Задача 15: Напишите программу, 
// которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write ("Введите день недели цифрой начиная с 1 (понедельник):  ");
int WEEK = Convert.ToInt32(Console.ReadLine());

bool NN (int WEEK)
{
    if (WEEK>5)
    {
    return true;
    }
    return false;
}

bool NM (int WEEK)
{
    if (WEEK<6)
    {
    return true;
    }
    return false;
}

bool MM (int WEEK)
{
    if (WEEK <8 && WEEK >0)
    {
    return true;
    }
    Console.WriteLine ("не день недели");
    return false;
}

if (MM ( WEEK))
{
    if (NM ( WEEK))
    {
        Console.WriteLine ("будний ");
    }
    else 
    {  
    Console.WriteLine ("выходной ");
    } 
}

