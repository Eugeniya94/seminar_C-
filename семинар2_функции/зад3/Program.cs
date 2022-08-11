// напишите программу, которая на вход будет принимать 2 числа и выводить,
//  является ли второе число кратно первому. Если число 2 не кратно числу 1, то
//  программа выводит остаток от деления.
//  34,5 => не кратно, остаток 4
//  16,4 => кратно

Console.Write("Введите 2 числа. первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void Endnumber (int fnum, int snum)
{
    int del = number % number2;
    if(del == 0)
    {
    Console.WriteLine($"число {number} кратно {number2}");
    }
    else{
          
        Console.WriteLine($"число {number} не кратно {number2}, остаток от деления равен {del}");
    }
}
Endnumber(number,number2);

