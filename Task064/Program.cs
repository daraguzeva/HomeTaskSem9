// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

int Nums(int N)
{
    Console.Write($"{N} ");
    if (N == 1)
        return 1;
    return N - Nums(N - 1);
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Nums(N);
