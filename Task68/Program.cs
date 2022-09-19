// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int number1 = 2;
int number2 = 2;

int Accerman (int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Accerman(n - 1, 1);
    if (n > 0 && m > 0) return Accerman(n - 1, Accerman(n, m - 1));
    return Accerman(n, m);
}

Console.WriteLine($" Значение функции Аккермана для {number1} и {number2} будет {Accerman (number1, number2)}.");