 void InputArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(1, 21);
            }
        }
    }
}
static void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine((i+1));
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + "("+i+","+j+","+k+")  ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
Console.Clear();
int n = 2;
int[,,] array = new int[n, n, n];
InputArray(array);
PrintArray(array);
