// Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.Write($"Квадрат числа {number} = {square}");


Console.Write("Введите целое число1: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число2: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
Console.WriteLine($"Квадрат числа {number1} = {square}");