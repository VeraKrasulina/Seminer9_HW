// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
int start = -5;
int end = 8;

string PrintNatNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    else if (start < 0) { start = 1; }
    return (start + ", " + PrintNatNumbers(start + 1, end));
}

Console.WriteLine(PrintNatNumbers(start, end));
