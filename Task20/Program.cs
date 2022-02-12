// Задать номер четверти, показать диапазоны для возможных координат.

Console.Clear();

Console.WriteLine("Введите номер четвети декартовой системы координат.");
int quad = Int32.Parse(Console.ReadLine());

switch (quad)
{
    case 1:
    Console.WriteLine("x > 0 и y > 0");
    break;

    case 2:
    Console.WriteLine("x < 0 и y > 0");
    break;

    case 3:
    Console.WriteLine("x < 0 и y < 0");
    break;

    case 4:
    Console.WriteLine("x > 0 и y < 0");
    break;
}
