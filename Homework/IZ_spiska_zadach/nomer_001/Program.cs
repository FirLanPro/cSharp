// Задача 15: Напишите программу, которая принимает на вход Слово, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write ("Введите день недели :  ");
string WEEK = Console.ReadLine();

string NN (string WEEK)
{
if (WEEK.ToLower() == "суббота" || WEEK.ToLower() == "воскресение")
    {
    return "выходной день";
    }
return "таких выходных дней нет";
}

string NM (string WEEK)
{
    if (WEEK.ToLower() == "понедельник"|| WEEK.ToLower() =="вторник"|| WEEK.ToLower() =="среда"|| WEEK.ToLower() =="четверг"|| WEEK.ToLower() =="пятница")
    {
    return "будний день";
    }
return "таких будних дней нет";
}
NN (WEEK);
string res = NN (WEEK);
Console.WriteLine(res);
NM ( WEEK);
string rez = NM (WEEK);
Console.WriteLine(rez);
