// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
void PrintNatural(int n, int m,int i)
{
    {
        if (n < m)
        {

            return;
        }
        if (n % 2 == 0)
        {
            i = n;
            
        }
                PrintNatural(n-1, m,i);
                
    }
    System.Console.Write($"{i}, ");
    return;
}
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
int i = 0;
PrintNatural(n,m,i);
System.Console.WriteLine(" ");

