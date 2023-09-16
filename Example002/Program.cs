/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumFromMToN(int min, int max)
{
    if (min == max + 1) return 0;
    return min + SumFromMToN(++min, max);
}

int startNum = InputNum("Input number M: ");
int endNum = InputNum("Input number N: ");

int resulSum = SumFromMToN(startNum, endNum);
System.Console.WriteLine(resulSum);
