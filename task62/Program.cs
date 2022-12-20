void RealeseSpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SpiralArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
          j++;
        }   
        else if (i < j && i + j >= array.GetLength(0) - 1)
        {
           i++;
        }         
        else if (i >= j && i + j > array.GetLength(1) - 1)
        {
           j--;
        }           
        else
        {
           i--;
        }     
    }

    RealeseSpiralArray(array);
}
int size = 4;
int[,] array = new int[size, size];
SpiralArray(array);