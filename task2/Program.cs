// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите положительное минимальное число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите положительное максимальное число: ");
int n = int.Parse(Console.ReadLine());

void Recursion(int m, int n, int summ)
{
    if (m > n)
    {
        Console.WriteLine(summ);
        return;
    }
    summ += m++;
    Recursion(m, n, summ);
}

Recursion(m, n, 0);