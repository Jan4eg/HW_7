/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

int Read (string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int m = Read("m");
int n = Read("n");
int a = Read("i-я позиция элемента");
int b = Read("j-я позиция элемента");

int[,] CreateArray(int m, int n, int a, int b)
{
    int [,] Array = new int [m,n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(0, 10);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
   for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i,j]+" " );
        }
        System.Console.WriteLine();
    } 
    if (a <= Array.GetLength(0) & b <= Array.GetLength(1))
    {System.Console.WriteLine(Array [a,b]);}
    else {System.Console.WriteLine("Такого числа нет");}
}

PrintArray(CreateArray(m, n, a, b));

