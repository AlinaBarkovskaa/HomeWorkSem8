void TransformationPascalTriangle(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int count = 0;
    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
    {
      if (matrix[i, j] != 0)
      {
        matrix[i, matrix.GetLength(1) / 2 + j - count] = matrix[i, j];
        matrix[i, j] = 0;
        count++;
      }
    }
  }
  matrix[matrix.GetLength(0) - 1, 0] = 1;
}
void FillPascalTriangle(double[,] pascalTriangle)
{
  for (int k = 0; k < pascalTriangle.GetLength(0); k++)
  {
    pascalTriangle[k, 0] = 1;
  }
  for (int i = 1; i < pascalTriangle.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
    }
  }
}
void Print(double[,] a)
{
  for (int i = 0; i < a.GetLength(0); i++)
  {
    for (int j = 0; j < a.GetLength(1); j++)
    {
      if (a[i, j] != 0)
      {
          Console.Write($"{a[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}
Console.Clear();
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] pascalTriangle = new double[n + 1, 2 * n + 1];
FillPascalTriangle(pascalTriangle);
Console.WriteLine();
Print(pascalTriangle);
TransformationPascalTriangle(pascalTriangle);
Console.WriteLine();
Print(pascalTriangle);

