// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

int Summ(int N, int M)
{
    if (N == M)
    { return N + M; }
    else
    { return N + Summ(N + 1, M);
     }
}
Console.Write(Summ(N, M));