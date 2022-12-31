// Задать массив m, n с рандомными
// вещественными элементами в диапазоне 
// между -9,9 и 9,9 с 1 знаком после запятой

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число строк массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double [,] matrix = new double[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(-9, 10) + new Random().Next(-9, 10) * 0.1;
    Console.Write(matrix[i, j] + " ");
  }
  Console.WriteLine();
}
