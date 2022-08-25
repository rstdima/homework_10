// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());


int PrintNumbersToN(int m, int n)
{
   if (m == 0)
      return n + 1;
   if (m > 0 && n == 0)
      return PrintNumbersToN(m - 1, 1);
   else
      return PrintNumbersToN(m - 1, PrintNumbersToN(m, n - 1));
}
Console.WriteLine($"A(m, n) = {PrintNumbersToN(m, n)}");
