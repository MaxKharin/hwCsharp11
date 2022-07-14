// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int m = Prompt("Enter your m number: ");
int n = Prompt("Enter your n number: ");
Console.WriteLine(A(m, n));

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}

int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}