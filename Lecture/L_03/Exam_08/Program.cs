// замена символов в тексте
string text = "аолрфр  алораоа овлаоа";    
          
string Replace( string text, char oldValue, char newValue) // Replace не объявлена
{
    string result = String.Empty;
    int length =text.Length;
    for (int i=0; i< length; i++)
    {
        if (text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    
    }
    return result;
}

string newText = text.Replace( " ", "|");
Console.WriteLine(newText);
Console.WriteLine();
newText= newText.Replace( "о", "HH");
Console.WriteLine(newText);
