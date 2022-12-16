int[,] fillArraySnake(int n)
{
    int[,] matrix = new int[n, n];
    int value = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i % 2 == 0)
        {
          for (int j = 0; j < matrix.GetLength(1); j++) 
          {
              matrix[i, j] = value;
              value++;
          }
        } else
        {
           for(int j = n -1; j >= 0; j--)
           {
              matrix[i, j] = value;
              value++;
           }
        }
    }
    return matrix;
}
void Print(int[,] matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
   {
     for(int j = 0; j < matrix.GetLength(1); j++)
     {
        Console.Write(matrix[i, j] + "\t");
     }
     Console.WriteLine();
   }
}

Console.Clear();
int n = 4;
int[,] array = new int[n, n];
int[,] matrix = fillArraySnake(n);
Print(matrix);