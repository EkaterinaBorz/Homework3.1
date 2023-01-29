// Показать кубы чисел, заканчивающихся на четную цифру

int number = 1;

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) Console.Write(cube + " ");
    number++;
}
Console.WriteLine();
