// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3},");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

int[,] SwapRowToCol(int[,]matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[,] newMatr = new int[row,col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
           newMatr[i,j]=matrix[j,i]; 
        }
    }
    return newMatr;
} 
 int[,] matr=CreateMatrixRndInt(3,3,1,10);
 PrintMatrix(matr);
 Console.WriteLine();
int[,]newMatr = SwapRowToCol(matr);
 PrintMatrix(newMatr);