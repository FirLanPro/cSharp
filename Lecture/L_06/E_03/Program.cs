//Чтение кода.
/// документация XML

//using System.Liqng;

string text = "(1,2) (2,3) (4,5) (6,6)"
                .Replace("(", "")//замена скобок
                .Replace(")","")//замена скобок
                ;
Console.WriteLine(text);

var data = text.Split(" ")//возьми текст, разбей; разделителем будет пробел
                .Select(item => item.Split(","))//выборка элементов, для кот. новое разбиение на несколько элеметов, символ разделителя запятая
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))//выборка из текущего массива. первая кооддината взятаи конвертирована в число и вторая коордю аналогично
                .Where(e => e.x%2 == 0)//проверка условий. первая координата четная
                .Select(point => (point.x*10, point.y))//увеличение первой координаты
                .ToArray();//конвертирование в явный массив
for (int i = 0; i< data.Length; i++)
{
    //Console.WriteLine(data[i]);
   // for (int k=0; k<data[i].Length;k++)
   // {
        Console.WriteLine(data[i]);
       // Console.WriteLine();
   // }
}
