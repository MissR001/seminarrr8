/*
Задача 60. ...Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)
*/

int[,,] CreateMatrixRndInt(int rows, int columns, int min, int max);

void PrintMatrix(int[,,] matrix)

void ReplaceFirstLastRows(int[,,] matrix)

{
  int[,,] array = new int[a, b, c];
  return array;
}

void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
  }
}

int [,] array3d = CreateMatrixRndInt(3, 4, 100, 100);
PrintMatrix(array3d);
Console.WriteLine();
ReplaceFirstLastRows(array3d);
PrintMatrix(array3d);

