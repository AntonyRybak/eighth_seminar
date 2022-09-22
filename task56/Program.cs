Console.Clear();
Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 9);

PrintArray(array);
int result = Sum(array);
PrintResult(array, result);

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
            Console.Write($"{filledArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int Sum(int[,] filledArray)
{
    int result = 0;
    int min = 1000;
    int temporarry = 0;
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        result = 0;
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            result = result + filledArray[i, j];
        }
        min = min > result ? result : min;
        temporarry = min;
        Console.WriteLine($"Результат строки №{i + 1} = {result}");
    }
    return temporarry;
}

void PrintResult(int[,] someArray, int some)
{
    int check = 0;
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        result = 0;
        check += 1;
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            result = result + someArray[i, j];

        }
        if (some == result)
            break;
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов: №{check} = {some}");
}