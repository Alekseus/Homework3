// Найти расстояние между точками в пространстве 2D/3D.

Console.Clear();

Console.WriteLine("Введите число измерений пространства: 2 или 3");
int dimension = Int32.Parse(Console.ReadLine());

if(dimension == 2)
{
    Console.WriteLine("Введите координату Х первой точки: ");
double x1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
double y1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки: ");
double x2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
double y2 = Int32.Parse(Console.ReadLine());

double sum = (((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2) ));
double result = Math.Sqrt(sum);
Console.WriteLine($"Расстояние между точками = {result}");
}

else
{
    Console.WriteLine("Введите координату Х первой точки: ");
double x1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
double y1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
double z1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки: ");
double x2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
double y2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
double z2 = Int32.Parse(Console.ReadLine());

double sum = (((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2) + (z1 - z2) ));
double result = Math.Sqrt(sum);
Console.WriteLine($"Расстояние между точками = {result}");
}








