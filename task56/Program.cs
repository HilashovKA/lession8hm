// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumRow(int[,] array, int row)
{
    int sum = 0;
    for (int column = 0; column < array.GetLength(1); column++)
    {
        sum +=  array[row,column];
    }
    return sum;
}

void MinSumRow(int[,] array)
{
    int minSum = SumRow(array, 0);
    int minRow = 0;
    for (int row = 1; row < array.GetLength(0); row++)
    {
        int sum = SumRow(array, row); //Чтобы дважды не считать сумму строки ввожу переменную sum.
        if(minSum > sum)  //На больших матрицах это будет ускорит вычисления
        { 
            minSum = sum; 
            minRow = row;
        }
    }
    Console.WriteLine($"Cтрока {minRow} с наименьшей суммой элементов = {minSum}");
}

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {1, 2, 1, 2},
    {8, 4, 2, 4},
    {1, 2, 1, 3}
};

PrintMatrix(array);
MinSumRow(array);