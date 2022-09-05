
// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int a1, int b1, int c1)
{
    if(a1+b1>c1 && b1+c1>a1 && c1+a1>b1)
    {
        return true;
    }
    return false;
}
bool result = CheckTriangle(a,b,c);
Console.Write(result? "Три числа являются треугольником":"Три числа не являются треугольником");
