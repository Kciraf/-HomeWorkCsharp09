// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AccermanFunc(int m, int n)
{
    int result = 0;
    if (m == 0)
    {
        result = n + 1;
    }
    else if (m > 0 && n == 0)
    {
        result = AccermanFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        result = AccermanFunc(m - 1, AccermanFunc(m, n - 1));
    }
    return result;
}

int[] arg = new int[2];
System.Console.WriteLine("Введите аргументы функции Аккермана через пробел (m n): ");
arg = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
System.Console.WriteLine($"Результат А({arg[0]}, {arg[1]}) = {AccermanFunc(arg[0], arg[1])}");