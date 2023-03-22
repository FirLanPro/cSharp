// в случайных точках консоли вывести случайные числа
Random r = new Random();

Console.CursorVisible = false;
while (true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeigth)  //Console не содержит определения WindowHeigth
    );
    Console.Write(r.Next(10));
    Thread.Sleep(1000);
}