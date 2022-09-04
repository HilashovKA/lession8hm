// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
// The same array with dimensions specified.
int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

void PrintArray3D(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++) Console.Write($"{array[k, i, j]} ({k},{i},{j}) \t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array = new int[2, 3, 4]
{
    {
    {11, 12, 13, 14},
    {15, 16, 17, 18},
    {19, 20, 21, 22}
    },
    {
    {23, 24, 25, 26},
    {27, 28, 29, 30},
    {31, 32, 33, 34}
    }
};

PrintArray3D(array);