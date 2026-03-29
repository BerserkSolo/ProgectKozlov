using System;

public class ProverkaNaProst
{
    // Расширенный алгоритм Евклида для поиска НОД и коэффициента x
    // x — это и есть наш будущий обратный элемент b
    public static long ExtendedNOD(long a, long n, out long x)
    {
        if (a == 0)
        {
            x = 0;
            return n;
        }
        long x1, y1;
        // Рекурсивно вычисляем НОД (наибольший общий делитель)
        long nod = ExtendedNOD_Internal(n % a, a, out x1, out y1);
        x = y1 - (n / a) * x1;
        return nod;
    }
  
    private static long ExtendedNOD_Internal(long a, long b, out long x, out long y)
    {
        if (a == 0)
        {
            x = 0; y = 1;
            return b;
        }
        long x1, y1;
        long nod = ExtendedNOD_Internal(b % a, a, out x1, out y1);
        x = y1 - (b / a) * x1;
        y = x1;
        return nod;
    }
}

class Program
{
    static void Main()
    {
        // Вводим числа a и n по очереди
        Console.Write("Введите число a: ");
        long a = long.Parse(Console.ReadLine());

        Console.Write("Введите число n: ");
        long n = long.Parse(Console.ReadLine());

        long x;
        // Вызываем наш метод и получаем НОД (nod)
        long nod = ProverkaNaProst.ExtendedNOD(a, n, out x);

        // Если НОД равен 1, значит числа взаимно простые и обратный элемент существует
        if (nod == 1)
        {
            // делаем остаток положительным (если x отрицательный)
            long result = (x % n + n) % n;
            Console.WriteLine($"Обратный элемент к числу {a} по модулю {n} равен: {result}");
        }
        else
        {
            // Если НОД > 1, обратного элемента не существует (выводим 0)
            Console.WriteLine("Обратного элемента не существует. НОД больше 1.");
            Console.WriteLine(0);
        }

        Console.WriteLine("\nДля завершения нажмите любую клавишу");
        Console.ReadKey();
    }
}
