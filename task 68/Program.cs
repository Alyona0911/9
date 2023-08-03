// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanaFunction ( int m, int n)
{
    if (m == 0 )  return n + 1 ;
    if (n == 0)  return  AkkermanaFunction(m - 1,1) ;
    return AkkermanaFunction(m - 1, AkkermanaFunction(m ,n -1));
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите число m: ");
int n = GetInput("Введите число n: "); 
Console.WriteLine($"{m} , {n} -> A(m,n) = {AkkermanaFunction(m,n)}");

