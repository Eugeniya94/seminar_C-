// напишите программу, которая выводит случайное число из отрезка [10,99] и 
// показывает наибольшую цифру числа. 78->8; 12->2; 85->8.


int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка [10;99]-> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit){
//     Console.WriteLine("Числа равны");
// }
// else{
// // int max = firstDigit ;
// // if( secondDigit > max) max = secondDigit;

//  int max = firstDigit > secondDigit ? firstDigit : secondDigit;

// Console.WriteLine($"Наибольшая цифра числа {number} => {max}");
// }


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10; 
    
    if (firstDigit == secondDigit) return -1;

    return firstDigit > secondDigit ? firstDigit : secondDigit;

}

int maxdigit = MaxDigit(number);
string result = maxdigit != -1 ? maxdigit.ToString() : "Цифры одинаковые"; 
//int maxdigit2 = MaxDigit(34);

Console.WriteLine($"Наибольшая цифра числа {number} => {result}");

//Console.WriteLine($"Наибольшая цифра числа {34} => {maxdigit2}");