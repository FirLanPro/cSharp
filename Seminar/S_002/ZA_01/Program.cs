// принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. вариант 1

14 -> нет 46 -> нет 161 -> да

int GetNumber(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

bool Check(int value)
{
  return value % 7 == 0 && value % 23 == 0;
}

string GetResult(int number, bool checkResult)
{
  string temp = String.Empty;
  if (checkResult) { temp = "YES"; }
  else { temp = "NO"; }
  return "Число: " + number + ". Итог: " + temp;
}

int value = GetNumber("Введите value: ");
bool flag = Check(value);
string output = GetResult(value, flag);
System.Console.WriteLine(output);
