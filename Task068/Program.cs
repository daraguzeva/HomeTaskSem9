// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

int A(int N, int M)
{
  if (N == 0)
    return M + 1;
  else
    if ((N != 0) && (M == 0))
      return A(N - 1, 1);
    else
      return A(N - 1, A(N, M - 1));
}
Console.WriteLine(A(N, M));