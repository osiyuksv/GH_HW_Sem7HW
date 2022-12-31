// вывести в строку среднее арифмитические столбцов
// рандомного массива m, n с со значениями 
// элементов от 1 до 9

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число колонок массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(1, 10);
    Console.Write(matrix[i, j] + " ");
  }
  Console.WriteLine();
}
Console.WriteLine();

for (int j = 0; j < matrix.GetLength(1); j++)
{
  double avarageSum = 0;
  double sumColumn = 0;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    sumColumn = sumColumn + matrix[i, j];
  }
  avarageSum = avarageSum + sumColumn / matrix.GetLength(0);
  Console.Write(avarageSum + " ");
}