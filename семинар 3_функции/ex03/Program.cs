// Напишите программу, которая принимает на вход координаты 2х точек и находит расстояние между ними
// в 2D пространстве.
// А(3,6); В(2,1)-> 5,09
// A(7,-5);B(1,-1)->7,21

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

double Pifagor(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}
double result = Pifagor(X1, Y1, X2, Y2);
Console.WriteLine($"Расстояние между точками:{Math.Round(result, 2)}");