// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();
int[] array = new int [20];
int count = 0;
for ( int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1, 1000);
  Console.Write( array[i] + " ");
}
for ( int j = 0; j< array.Length; j++)
{
  if (j % 2 == 1) count = count + array[j];
}
Console.WriteLine();
Console.Write($"Сумма чисел, стоящих на нечетной позиции = {count} ");


