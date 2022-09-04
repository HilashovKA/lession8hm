// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SortingMatrix(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, j] < matrix[k, minPosition])
                {
                    minPosition = j;
                }
            }
            int temp = matrix[k, i];
            matrix[k, i] = matrix[k, minPosition];
            matrix[k, minPosition] = temp;
        }
    }
}

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};

PrintMatrix(array);
SortingMatrix(array);
Console.WriteLine();
PrintMatrix(array);