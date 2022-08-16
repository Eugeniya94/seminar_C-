// Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5-> 1,4,9,16,25.
// 2-> 1,4.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Таблица квадратов от 1 до {number}: ");
int count = 1;
while (count <= number)
{
    Console.WriteLine($"{count}-> {Math.Pow(count, 2)}");
    count++;
}