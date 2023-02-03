// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


Console.Clear();
int[] array = new int [20];
int count = 0;
for ( int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1, 1000);
  Console.Write( array[i] + " ");
}

int max = array[0];
int min = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом = ");
Console.Write(max - min);