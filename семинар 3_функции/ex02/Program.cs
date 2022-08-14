// напишите программу, которая по заданному номеру четверти
//  показывает диапазон возможных координат точек в этой четверти (x,y)

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

string Range (int num)
{
    if (num == 1) return "Значение переменных: x > 0 && y > 0";
    if (num == 2) return "Значение переменных: x < 0 && y > 0";
    if (num == 3) return "Значение переменных: x < 0 && y < 0";
    if (num == 4) return "Значение переменных: x > 0 && y < 0";
  return "Введены некорректные координаты";
 
}
 string result = Range(number);
 Console.WriteLine(result);
