/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int m = Read("m");
int n = Read("n");

int Read (string arg)
{
    System.Console.WriteLine($"Введите: {arg}");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int [,] CreateArray (int m, int n)
{
    int [,] Array = new int [m,n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(0,10);
            System.Console.Write($"{Array[i,j]} ");
        }
        System.Console.WriteLine();
    }
    return Array;
}

double [] MidSum (int [,] Array, int m, int n)
{
    double [] array = new double [Array.GetLength(1)];
    
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sum += Array[i, j];
        }
        array[j] = sum/m;
        sum = 0;
    }
    System.Console.WriteLine(" ");
    return array;
}

void PrintArray(double [] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write(array[j] + " ");
    }
    System.Console.WriteLine(" ");
}


double [] array = MidSum(CreateArray(m, n), m, n);
PrintArray(array);

