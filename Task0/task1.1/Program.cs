// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int square_num1 = number1 * number1;

if (number2 == square_num1)
    {
        Console.WriteLine($"Второе число {number2} является квадратом первого числа {number1}");
    } 

else 
{
  Console.WriteLine($"Второе число {number2} НЕ является квадратом первого числа {number1}");  
}
   
