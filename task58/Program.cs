int[,] InputArray(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return matrix;
}

int[,] FindProductTwoMtrices(int[,]matrix, int[,]matrix2)
{
    int[,] rezultMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
       for(int i = 0; i < matrix.GetLength(0); i++)
       {
          for(int j = 0; j < matrix2.GetLength(1); j++)
          {
             rezultMatrix[i, j] = matrix[i,j] * matrix2[i,j];
            
          }
       }
       return rezultMatrix;
    }
void Print(int[,] rezultMatrix)
{
   for(int i = 0; i < rezultMatrix.GetLength(0); i++)
   {
     for(int j = 0; j < rezultMatrix.GetLength(1); j++)
     {
        Console.Write(rezultMatrix[i, j] + "\t");
     }
     Console.WriteLine();
   }
}
Console.Clear();
Console.Write("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = InputArray(n, m);
Console.WriteLine();
int[,] matrix2 = InputArray(n, m);
int[,] rezult = FindProductTwoMtrices(matrix, matrix2);
Console.WriteLine();
Print(rezult);
