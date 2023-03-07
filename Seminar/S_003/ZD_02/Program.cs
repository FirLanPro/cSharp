// Кубы чисел от 1 до N
int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
string GetResult(int n)
{
    string result = String.Empty;
    int index =1;
    while (index<=n)
    {
        int sqr = index*index*index;
        result =result + "[" + index + "=>" + sqr + "]";
        index = index +1;
    }
    return result;
}
int n=GetNumber("введите кончное число: ");
Console.Write(GetResult(n));



