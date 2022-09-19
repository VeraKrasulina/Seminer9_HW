// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int start = -2;
int end = 4;

int SummNatNumbers(int begin, int end)
{
    if (begin == end) return begin;
    else if (begin < 0) {begin = 1;}
    return (begin += SummNatNumbers(begin + 1, end));
}

Console.WriteLine(SummNatNumbers(start, end));