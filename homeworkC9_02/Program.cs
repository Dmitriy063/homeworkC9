// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
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
void Summ(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  Summ(m, n - 1, summ);
}
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
int temp = 0;
PrintNatural(n,m);
System.Console.WriteLine(" ");
Summ(m, n, temp);

