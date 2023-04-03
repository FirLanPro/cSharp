// Замена символов в тексте
string text = "аолрфр  алораоа овлаоа";  
string newText = text.Replace( " ", "|");
Console.WriteLine(newText);
Console.WriteLine();
newText= newText.Replace( "о", "HH");
Console.WriteLine(newText);

