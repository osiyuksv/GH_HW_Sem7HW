//Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число колонок массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Задайте позицию элемента по строкам");
int mRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте позицию элемента по колонкам");
int mColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(10);
    Console.Write(matrix[i, j] + " ");
  }
  Console.WriteLine();
}
if (matrix.GetLength(0) >= mRows & matrix.GetLength(1) >= mColumns)
{
  Console.WriteLine($"Заданный элемент на позиции [{mRows}, {mColumns}] равен {matrix[mRows - 1, mColumns - 1]}");
}
else Console.WriteLine($"Элемента на позиции [{mRows}, {mColumns}] в массиве нет");