// Напишите программу, которая на вход принимает число N и выдает произведение всех чисел от 1 до N.
// 4->24
// 5->120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int mult = 1;

// for (int i = 1; i <= number; i++)
// {
//     mult *= i;
// }
//Console.WriteLine($"Произведение чисел от 1 до {number} равна {mult}");

int MultNum(int num)
{
 int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }
    return mult;
}
int res = MultNum(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равна {res}");