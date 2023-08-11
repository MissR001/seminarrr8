/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int[] CreateMatrixRndInt(int rows, int columns, int min, int max);
int [][] matrix1 = {{2,4}, {3,2}};
int[][] matrix2 = {{3,4} {3,3}};



void PrintMatrix(int[,] matrix)

void ReplaceFirstLastRows(int[,] matrix)
{
int rows1=matrix1.lenght;
int colomns1=matrix1[0].lenght;
int rows2=matrix2.length;
int colomns2=matrix2[0].lenght;

for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1x.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int [] array = CreateMatrixRndInt(3, 4, 100, 100);
PrintMatrix(array);
Console.WriteLine();
ReplaceFirstLastRows(array);
PrintMatrix(array);