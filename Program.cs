// Урок 9. Рекурсия
// Все задачи решаются с помощью рекурсии

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// сделать то же самое, что и на семинаре, только в обратную сторону

// void Сountdown(int N)
// {
//     if(N == 0) // пружинка раскрутится. Принцип стЭка, берется сначала верхнее значение и идет к низу
//     {
//         return;
//     }
// Console.Write(N + " ");
// Сountdown(N-1);
// }

// Console.WriteLine("Введите число, от которого надо отсчитать до 1:");
// int N = Convert.ToInt32(Console.ReadLine());
// Сountdown(N);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30 (4+5+6+7+8=30)

// int ArifmP(int s, int f)
// {
//     int sum = 0;
//     sum = sum + s;
//     if(s == f-1) // пока конечное число не станет равным начальному
//     {
//         s++;
//         // Console.WriteLine(sum + " if " + " начальное " + s + " конечное " + f);
//         return sum += s;
//     }
//     else
//     {
//         // Console.WriteLine(sum + " else " + " начальное " + s + " конечное " + f);
//         return sum = s + ArifmP(s+1,f);
//     }
// }

// Console.WriteLine("Введите число, от которого надо складывать:");
// int start = Convert.ToInt32(Console.ReadLine()); // начальное число
// Console.WriteLine("Введите число, до которого надо складывать:");
// int final = Convert.ToInt32(Console.ReadLine()); // конечное число
// int sum = ArifmP(start, final);
// Console.WriteLine("Итоговая сумма: " + sum);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetAck(int n, int m)
{
    if (n == 0) 
    {
        return m + 1;
    }
    if (n!=0 && m == 0) 
    {
        return GetAck(n - 1, 1);
    }
    else // n > 0 && m > 0
    {
        return (GetAck(n - 1, GetAck(n, m - 1)));
    }
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine()); // начальное число
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine()); // конечное число
int ackerman = GetAck(m, n);
Console.WriteLine(ackerman);