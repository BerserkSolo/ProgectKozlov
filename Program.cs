using System;

/* Суть алгоритма Евклида,который будет использоваться в классе:
 * двух чисел не меняется, если большее число заменить на остаток от деления его на меньшее.
* Повторяем эту операцию, пока одно из чисел не станет равно нулю. Тогда второе число и есть НОД.*/

public class ProverkaNaProst
{
    //алгоритм Евклида
    private static int NOD(int a, int n)
    {
        while (n!= 0)
        {
            int temp = n;
            n = a % n;
            a = temp;
        }
        return a;
    }

    // Метод, проверяющий, являются ли a и n взаимно простыми
    public static bool True(int a, int n)
    {
    // Взаимно простые числа - это числа, у которых НОД = 1
        return NOD(a,n) == 1;
    }
}

class Program
{
    static void Main()
    {
        bool Res = false;
        int a;
        int n;
        int b = 0;
        int c= 1;
        Console.WriteLine("Введите a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите n: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (ProverkaNaProst.True(a, n))
        {
            Console.WriteLine($"Числа {a} и {n} — взаимно простые.");
            for (b = 0; Res == false; b++) 
            {
                if (((a * b) % n) == c)
                {
                    Res = true;
                    Console.WriteLine($"b = {b}");
                }
                else
                {
                    Res = false;
                }
            }
        }

        else
        {
            Console.WriteLine($"Числа {a} и {n} — не взаимно простые.");
            Console.WriteLine("0");
        }
    }
}
