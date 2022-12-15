void InputArray(int[,] matrix)
 {
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
          matrix[i, j] = new Random().Next(0, 11);
           Console.Write($"{matrix[i, j]} \t");
       }
        Console.WriteLine();
    }
 } 
int SumRowElements(int[,] matrix, int i)
{
  int sumRow = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumRow += matrix[i,j];
  }
  return sumRow;
}

Console.Clear();
Console.Write("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputArray(matrix);
Console.WriteLine();
int minSumRow = 0;
int sumRow = SumRowElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SumRowElements(matrix, i);
  if (sumRow > temp)
  {
    sumRow = temp;
    minSumRow = i;
  }
}
Console.WriteLine($"Строкa с наименьшей суммой элементов = {minSumRow + 1} ");
