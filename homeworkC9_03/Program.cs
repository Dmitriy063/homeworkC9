// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
void PrintNatural(int n, int m)
{
    {
        if (n < m)
        {
            return;
        }
        PrintNatural(n - 1, m);
    }
    System.Console.Write($"{n}, ");
}
int FunctionAkker(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAkker(m - 1, 1);
  else return FunctionAkker(m - 1, FunctionAkker(m, n - 1));
}
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
PrintNatural(n,m);
Console.Write($"Функция Аккермана = {FunctionAkker(m, n)} ");


