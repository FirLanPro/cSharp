// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double Input (string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double Equation (double b1,double k1,double b2 ,double k2)
{
    if (k1!=k2)
    {
        double x;
        double y;
        x =(b2-b1)/(k1-k2);
        y=k1*x+b1;
        Console.WriteLine($"координаты точки пересечения: ({x} , {y})");
    }
    return 0;
}

void NotCrossing (double k1,double k2)
{
    
    if (k1==k2)
    {
        Console.WriteLine ("прямые не пересекаются");
    }
}

void InputOutput()
{
double k1 =Input("значение коэффициета k1: ");
double b1 =Input("значение b1: ");
double k2 =Input("значение коэффициета k2: ");
double b2 =Input("значение b2: ");
Equation ( b1, k1, b2, k2);
Console.WriteLine();
NotCrossing(k1, k2);
}

InputOutput();