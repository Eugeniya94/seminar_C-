// Напишите программу, которая на вход принимает точки (X,Y), причем x!= 0 и Y!=0 и
//  выдает номер четверти плоскости, в которой находится эта точка.
//  1 четверть: x+; Y+
//  2: x-;Y+
//  3: x-;Y-
//  4:x+;Y-.

Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0)
// {
// Console.WriteLine("Первая четверть");
// }
// else if (X < 0 && Y < 0)
// {
// Console.WriteLine("Третья четверть");
// }
// else if (X > 0 && Y < 0)
// {
// Console.WriteLine("Четвертая четверть");
// }
// else if (X < 0 && Y > 0)
// {
// Console.WriteLine("Вторая четверть");
// }
// else {
//     Console.WriteLine("Введены некорректные координаты");
// }

string Quarter (int xa, int ya)
{
    if (xa > 0 && ya > 0) return "Первая четверть";
    if (xa < 0 && ya < 0) return "Третья четверть";
    if (xa > 0 && ya < 0) return "Четвертая четверть";
    if (xa < 0 && ya > 0) return "Вторая четверть";
  return "Введены некорректные координаты";
 
}
 string result = Quarter(X,Y);
 Console.WriteLine(result);
 




