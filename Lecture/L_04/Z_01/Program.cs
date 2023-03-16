// 
string[,] table = new string[2,3];
table[1,2]="слово";

for (int rows=0;rows<2;rows++)
{
    for(int columns=0;columns<3;columns++)
    {
    Console.WriteLine ($"-{table[rows,columns]}-");
}
}

int [,] matrix = new int [3,4];

for (int i=0;i<matrix.GetLength(0);i++)
{
    for(int j=0; j<matrix.GetLength(1);j++)
    {
        Console.Write($"{matrix[i,j]}");
    }
    Console.WriteLine();
}