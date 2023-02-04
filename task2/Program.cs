// Задать двумерный массив следующим правилом: Aₘₙ = m+n
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
            arg[i,j] = i+j;
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
