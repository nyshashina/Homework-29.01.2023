// Показать двумерный массив размером m×n заполненный вещественными числами
void PrintMatrix(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i,j]} \t ");
        }
        Console.WriteLine();
    }

}

void FillMatrix(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(-99,100);
        }
    }
}

Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов");
int numberN = int.Parse(Console.ReadLine() ?? "0");

double[,]matrix = new double[numberM, numberN];

FillMatrix(matrix);
PrintMatrix(matrix);