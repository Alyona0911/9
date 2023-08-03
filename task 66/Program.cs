// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers (int m ,int n )
{
    if (m >= n) return m ;
    return m + SumNaturalNumbers (m + 1 ,n) ;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите число m: ");
int n = GetInput("Введите число n: ");   
Console.WriteLine($"Сумма натуральных чисел от {m} до  {n} -> {SumNaturalNumbers(m,n)}");
