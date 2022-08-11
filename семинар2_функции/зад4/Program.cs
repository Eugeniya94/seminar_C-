// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одномременно 7 и 23.
// 14 -> no
// 46-> no
// 161 -> yes

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Endnum(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

bool result = Endnum(number);
string res = result ? "true" : "false";
Console.Write(res);