//Найти кубы чисел от 1 до N.


Console.Clear();

Console.Write("Введите число, чтобы задать ряд натуральных чисел от 1 до N для возведения в куб: ");
int N = Int32.Parse(Console.ReadLine());

int i;
for (i = 1; i <= N; i++)
{
    Console.WriteLine();
    Console.Write(i + " ");
    Console.Write(i * i * i + " ");
}