// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i,j]}\t");
        }
        Console.WriteLine();
    }

}

void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(1,10);
        }
    }
}

void ChangedMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0){
                arg[i,j] = arg[i,j] * arg[i,j];
            }
        }
    }
}

Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов");
int numberN = int.Parse(Console.ReadLine() ?? "0");

int[,]matrix = new int[numberM, numberN];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Заменили элементы, у которых оба индекса чётные, на их квадраты:");
ChangedMatrix(matrix);
PrintMatrix(matrix);