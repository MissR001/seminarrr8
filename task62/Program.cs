/*Задача 62. Напишите программу, которая заполнит 
спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/



int n = 4;
int[,] spiralMatrix = new int[n, n];

int i = 1;
int j = 0;
int k = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = i;
  i++;
  if (j <= k + 1 && j + k < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (j < k && j + k >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (j >= k && j + k > spiralMatrix.GetLength(1) - 1)
    k--;
  else
    j--;
}

WriteArray(spiralMatrix);

void WriteArray (int[,] array)
{
  for (int j = 0; j < array.GetLength(0); j++)
  {
    for (int k = 0; k < array.GetLength(1); k++)
    {
      if (array[j,k] / 10 <= 0)
      Console.Write($" {array[j,k]} ");

      else Console.Write($"{array[j,k]} ");
    }
    Console.WriteLine();
  }
}