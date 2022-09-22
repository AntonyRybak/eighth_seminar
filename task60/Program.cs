Console.Clear();
Console.WriteLine($"\nВведите размер массива X  Y  Z:");
Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine("");

int[,,] arrayCube = new int[x, y, z];
CreateArray(arrayCube);
WriteArray(arrayCube);

void WriteArray(int[,,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < someArray.GetLength(2); k++)
            {
                Console.Write($"Z({k})={someArray[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] someArray)
{
    int[] temp = new int[someArray.GetLength(0) * someArray.GetLength(1) * someArray.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < someArray.GetLength(0); x++)
    {
        for (int y = 0; y < someArray.GetLength(1); y++)
        {
            for (int z = 0; z < someArray.GetLength(2); z++)
            {
                someArray[x, y, z] = temp[count];
                count++;
            }
        }
    }
}