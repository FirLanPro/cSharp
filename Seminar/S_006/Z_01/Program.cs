// Задайте массивю Напишите программу, которая определяет, присутствует ли заданное число в массиве.
bool Check (int [] array, int el)
{
    int size = array.Length;
    for (int i = 0; i < size; i++ )
        if (array[i] ==el ) return true;
    return false;
}

string PrintResult (int[] array, int el, bool exist)
{
    if(exist) return $"В массиве {String.Join(" ",array)} элемент {el} присутствует";
    return "В массиве элемента нет";
}
int [] arr = {1,2,3,4,5,6,7,8,9};
int find = 2;
bool c = Check(arr,find);
System.Console.WriteLine(PrintResult(arr,find,c));
