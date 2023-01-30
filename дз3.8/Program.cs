// Определить, присутствует ли в заданном массиве, некоторое число

int[] array = new int[5];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0, 20);
  Console.Write(array[i] + " ");

}
Console.WriteLine();

Console.Write("Введи число, которое необходимо найти: ");
int number = int.Parse(Console.ReadLine() ?? "");

for (int j = 0; j < array.Length; j++) 
{
  if (array[j] == number) count = 1;
}
if (count > 0) Console.WriteLine("Такое число в массиве есть. ");
else Console.WriteLine("Такого числа в массиве нет.");

