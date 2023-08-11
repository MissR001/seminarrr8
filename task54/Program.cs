// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max);

void PrintMatrix(int[,] matrix)

void ReplaceFirstLastRows(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLenght(0) - 1;
     

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    
}

int [,] array2d = CreateMatrixRndInt(3, 4, 100, 100);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceFirstLastRows(array2d);
PrintMatrix(array2d);

