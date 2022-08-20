// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да 

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);

    }
    return array;
}

bool TrueFalse(int[] arr, int findEl)
{
    bool ret = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findEl)
        {
            ret = true;
            break;
        }
    }
    return ret;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);// добавляем последний элемент в массив
    Console.Write("]");
}

Console.WriteLine("Введите число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(12,-9,9);
PrintArray(arr);
bool search = TrueFalse(arr,findNumber);
Console.WriteLine();

Console.WriteLine(search ?
 $"Число {findNumber} присутствует в массиве" : $"Число {findNumber} отсутствует в массиве");