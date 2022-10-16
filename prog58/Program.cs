/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] FirstMatrix = Myarray(3, 3);
Print2DArray(FirstMatrix);
int[,] SecondMatrix = Myarray(3, 3);
Console.WriteLine();
Print2DArray(SecondMatrix);
Console.WriteLine();
 
Print2DArray(MultiplicationMatrix(FirstMatrix, SecondMatrix));

int[,] Myarray(int height, int wight)
{
    int[,] TwoDArray = new int[height, wight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < wight; j++)
        {
            TwoDArray[i, j] = new Random().Next(0, 10);
        }
    }
    return TwoDArray;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] MatrixFirst, int[,] MatrixSecond)
{
    int[,] MatrixThird = new int[MatrixFirst.GetLength(0), MatrixSecond.GetLength(1)];
    for (int i = 0; i < MatrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixSecond.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixSecond.GetLength(0); k++)
            {
                MatrixThird[i, j] += MatrixFirst[i, k] * MatrixSecond[k, j];
            }
        }
    }
    return MatrixThird;
}
