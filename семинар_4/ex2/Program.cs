// Напишите программу,которая принимает на вход число и выдает количество цифр в числе.
// 456->3
// 78->2
// 89126->5



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNum(int num)
{
    int count = 1;
    while (num >= 10)
    {
        num = num / 10;
        count++;
    }
    return count;
}
int res = CountNum(number);
Console.WriteLine($"Количество цифр в числе равно {res}");

// for (; number >=10;number = number/10)
// {
//    count++; 
// }
// Console.WriteLine($"Количество цифр в числе равно {count}");