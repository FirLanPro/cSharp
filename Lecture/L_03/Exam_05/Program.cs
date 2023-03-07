// Виды методов: 4. возвращ и приним
string Method4(int count, string c)
{
    int i=0;
    string result=""; // String.Empty;
    while (i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4 (10, "asnf ");
Console.WriteLine(res);