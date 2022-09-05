// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// 1. перевести двумерный массив в одномерный.
// 2.отсортировать массив(использовать готовый метод:(ArraySort)).

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)// row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }


    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

int[] ConvertMatrix2ArraySort(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        result[count] =matrix[i,j];
        count++;
        }
    }
     Array.Sort(result);
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

void CountSimularElem(int []array)
{
    int count = 1;
    int number=array[0];
    for (int i = 1; i < array.Length; i++)
    {
       if( array[i] == number) count++;
        else 
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }
        if(i==array.Length-1)
        {
            Console.WriteLine($"{number} -> {count}");
        }
    }
}

int [,]matr = CreateMatrixRndInt(3,3,1,9);
PrintMatrix(matr);

Console.WriteLine();
int[]array= ConvertMatrix2ArraySort(matr);
PrintArray(array);
Console.WriteLine();
CountSimularElem(array);



