// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число степени: ");
int B = int.Parse(Console.ReadLine());

int Sum = 1;
for (int i = 1; i <= B; i++)
{
    Sum*=A;
}
Console.WriteLine(Sum);