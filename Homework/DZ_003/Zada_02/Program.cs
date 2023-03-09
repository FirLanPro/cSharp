// метод(-ы), который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// корень из x2-x1 в квадрате + y2-y1 в квадрате + z2-z1 в квадрате

int x1 = 4, y1 = 4, z1 = 3,
    x2 = 5, y2 = 7, z2 = 6;

double formula (int x1, int x2, int y1,int y2, int z1,int z2)
{
int a=x2-x1;
int b=y2-y1;
int c=z2-z1;
double d = Math.Sqrt(a+b+c);
return d;
}
formula(x1,x2,y1,y2,z1,z2);
double res = formula(x1,x2,y1,y2,z1,z2);
Console.WriteLine ($"расстояние= {res}");