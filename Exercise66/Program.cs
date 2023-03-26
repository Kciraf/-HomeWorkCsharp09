// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumSegmentSum(int start, int end)
{
    int result = 0;
    if (start <= end)
    {
        return result += start + NumSegmentSum(start + 1, end);
    }
    return result;
}

System.Console.WriteLine("Введите число начало вывода: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число конца вывода: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = 0;

if (m > n)
{
    temp = m;
    m = n;
    n = temp;
}

System.Console.WriteLine("Сумма чисел в данном промежутке: " + NumSegmentSum(m, n));