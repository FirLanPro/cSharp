// Рекурсия 
// Собрать строку с числами от a до b, a<=b. вывод от меньшего к большему.

string NumberFor(int a, int b) // итеративный метод
{
    string result = String.Empty;
    for (int i =a; i <= b; i++) // от большего к меньшему. заменить инкремент на декримент
    {
        result += $"{i}";
    }
    return result;
}

string NumberRec(int a, int b) // рекурсия
{
    if (a <=b) return $"{a}" + NumberRec(a+1, b);// поменять местами в сборке строки. а и NumberRec
    else return String.Empty;
}

Console.WriteLine (NumberFor(1, 10));
Console.WriteLine(NumberRec(1, 10));