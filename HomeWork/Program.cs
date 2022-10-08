// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
//1 -3 8 -9
//  8 7 -7 9

/*
Console.WriteLine("Количество строк (m): ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов (n): ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -99, 99);
PrintArray(array);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

/*
int rows = 3;
int columns = 4;

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine("Введите индекс (i) позиции элемента: ");
int i = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите индекс (j) позиции элемента: ");
int j = int.Parse(Console.ReadLine()!);

if ((i >= 0) && (i <= 2))
	{
		if ((j >= 0) && (j <= 3))
			{
				Console.WriteLine($"i = {i}, j = {j} -> {array[i,j]}");
			}
		else Console.WriteLine($"i = {i}, j = {j} -> такого числа в массиве нет");
	}
else Console.WriteLine($"i = {i}, j = {j} -> такого числа в массиве нет");
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int rows = 3;
int columns = 4;

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);

double sum0 = 0;
    	for (int i = 0; i < array.GetLength(0); i++)
		{
            for (int j = 0; j < array.GetLength(1); j++)
			{
				if (j == 0)
					{
						sum0 = array[i, j] + sum0;
					}
			
			}
		}
		sum0 = sum0 / rows;

double sum1 = 0;
    	for (int i = 0; i < array.GetLength(0); i++)
		{
            for (int j = 0; j < array.GetLength(1); j++)
			{
				if (j == 1)
					{
						sum1 = array[i, j] + sum1;
					}
			
			}
		}
		sum1 = sum1 / rows;

double sum2 = 0;
    	for (int i = 0; i < array.GetLength(0); i++)
		{
            for (int j = 0; j < array.GetLength(1); j++)
			{
				if (j == 2)
					{
						sum2 = array[i, j] + sum2;
					}
			
			}
		}
		sum2 = sum2 / rows;

double sum3 = 0;
    	for (int i = 0; i < array.GetLength(0); i++)
		{
            for (int j = 0; j < array.GetLength(1); j++)
			{
				if (j == 3)
					{
						sum3 = array[i, j] + sum3;
					}
			
			}
		}
		sum3 = sum3 / rows;

Console.WriteLine($"Среднее арифметическое каждого столбца: {sum0}, {sum1}, {sum2}, {sum3}, ");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < m; i++) //по строкам
		{
            for (int j = 0; j < n; j++) //по столбцам
			{
				result[i,j] = new Random().Next(minValue, maxValue + 1);
			}
		}
	return result;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++) //по строкам
		{
            for (int j = 0; j < array.GetLength(1); j++) //по столбцам
			{
			Console.Write($"{ array[i,j]} ");
			}
			Console.WriteLine();
		}
}