/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

int Read(string arg)
{
    System.Console.Write($"Введите число {arg}: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

int m = Read("m");
int n = Read("n");

double [,] CreateArray (int m, int n)

{
    double [,] matrix = new double [m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(((Math.Round(new Random().NextDouble() *10, 2)) - 5) *10, 2);
            System.Console.Write($"{ matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
    return matrix;
}


CreateArray (n, m);
