int[,,] InputMatrix(int[,,] ma)
{
    int n = 2;
    int[,,] matrix = new int[n, n, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                Console.Write(matrix[i, j, k] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return matrix;
}
void MatrixOutputAlongWithIndices(int[,,] matrix, int n)
{
    int index = 0;
    while (matrix.Length != n - 1)
    {
        index++;
    }
    Console.Write($"matrix[i{index}, j{index}, k{index}] \t");
}
Console.Clear();
int[, ,] array = InputMatrix(array);
MatrixOutputAlongWithIndices(matrix, n);