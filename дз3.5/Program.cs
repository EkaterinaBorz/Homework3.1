// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine();
Console.Write("Введите число: ");

string writeN = Console.ReadLine();

int N = Convert.ToInt32(writeN);

int GetNumberProduct(int i)
{
  int prod = 1;
  

  for (int numb = 1; numb <= i; numb++)
  {
    prod = prod * numb;
    
  }

  return prod;
}


Console.WriteLine($" Произведение чисел от 1 до {N} составляет {GetNumberProduct(N)}");