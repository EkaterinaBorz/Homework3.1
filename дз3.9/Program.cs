// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[20];
int count = 0;
int Notcount = 0;

Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(100, 1000);
  Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
if (array [j]%2 == 0 ) count = count +1;

else Notcount = Notcount + 1;

}
Console.WriteLine(" Четные числа из массива: " + count);
Console.WriteLine();
Console.WriteLine(" Нечетные числа из массива: " + Notcount);