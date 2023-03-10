// Найти кубы чисел от 1 до N

Console.WriteLine();

Console.Write("Введите число:   ");
string write = Console.ReadLine();
int N = Convert.ToInt32(write);


int[] GetCubeTable(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{number} ^ 3 = ");
        Console.WriteLine(array[i]);
        number++;
    }
}

int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);