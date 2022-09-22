Console.Clear();
Console.WriteLine();
Console.Write("Матрица А. Введите количество строк: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Матрица А. Введите количество столбцов: ");
int columns1 = int.Parse(Console.ReadLine());
Console.Write("Матрица В. Введите количество строк: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Матрица В. Введите количество столбцов: ");
int columns2 = int.Parse(Console.ReadLine());
if (rows1 != columns2)
{
    Console.WriteLine("Умножение не возможно!");
}
else
{
    int[,] matrix1 = FillArray(rows1, columns1, 1, 11);
    int[,] matrix2 = FillArray(rows2, columns2, 1, 11);
    Console.WriteLine();
    PrintArray(matrix1);
    Console.WriteLine();
    PrintArray(matrix2);
    Console.WriteLine();
    PrintArray(MatrixProduct(matrix1, matrix2));
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
                matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
        }
    }
    return matrix3;
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] filledArray)
{
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            Console.Write($"{filledArray[i, j]} ");
        }
        Console.WriteLine();
    }
}