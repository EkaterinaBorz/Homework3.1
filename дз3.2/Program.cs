// Найти сумму чисел от 1 до А

Console.WriteLine();
Console.Write("Введите число: ");

string writeA = Console.ReadLine();

int A = Convert.ToInt32(writeA);

int GetNumberSum(int A)
{
  int number = 1;
  int sum = 0;

  for (int i = 0; i < A; i++)
  {
    sum = sum + number;
    number++;
  }

  return sum;
}

int NumberSum = GetNumberSum(A);
Console.WriteLine($" Сумма чисел от 1 до{A} составляет {NumberSum}");
