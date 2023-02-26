
Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "имя")
{
    Console.WriteLine("Ура Имя");
}
else
{
    Console.Write("текст, ");
    Console.WriteLine(username);
}
