﻿// замена символов в тексте
string text = "аолрфралораоаовлаоа";    ///аргумент не удается преобразовать
          
string Replace( string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length =text.Length;
    for (int i=0; i< length; i++)
    {
        if (text[i]=oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    
    }
    return result;
}
string newText = Replace(text, " ", "|");
Console.WriteLine(newText);
Console.WriteLine();
newText= Replace(newText, "о", "HH");
Console.WriteLine(newText);
