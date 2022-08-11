// Напишите программу, которая на вход принимает 2 числа и проверяет,
// является ли одно число квадратом другого
// 5,25 -> yes
// -4,16 -> yes
// 8,9 -> no

Console.Write("Введите два числа. Первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Endnum(int num,int num2 )
{
    return num * num == num2 || num2 * num2 == num;

}
bool result = Endnum(number,number2 );
string res = result ? "true" : "false";
Console.Write(res);
