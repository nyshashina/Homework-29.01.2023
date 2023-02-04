// В матрице чисел найти сумму элементов главной диагонали
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

void SumDia(int[,] arg)
{
    int sum = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            if (i == j){
                sum = sum + arg[i,j];
            }
        }
    }
    Console.WriteLine("Сумма элементов главной диагонали равна " + sum);
}

Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов");
int numberN = int.Parse(Console.ReadLine() ?? "0");

int[,]matrix = new int[numberM, numberN];

FillMatrix(matrix);
PrintMatrix(matrix);
SumDia(matrix);