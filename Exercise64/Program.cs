// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumPrint(int num)
{
    if (num >= 1)
    {
        System.Console.Write($"{num} ");
        num -= 1;
        NumPrint(num);
    }
}


System.Console.WriteLine("ВВедите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1)
{
    NumPrint(n);
}
else System.Console.WriteLine("В данном промежутке нет натуральных чисел");
