// Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз,
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,...
// Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
//N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int number = Prompt("Enter your number: ");
Print(number);
Console.WriteLine();

void Print(int number)
{
    if(number > 1)
        Print(number - 1);
 
    for (int i = 0; i < number; i++) 
        Console.Write($"{number}, ");
}

int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}