// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
//1 -3 8 -9
//  8 7 -7 9

Console.WriteLine("Количество строк (m): ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов (n): ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -99, 100);
PrintArray(array);

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