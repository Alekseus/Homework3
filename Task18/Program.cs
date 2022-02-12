//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Clear();
Console.WriteLine();

int a = 3;
int b = 5;
int x = a;
int y = b;

bool XY = x != a | y == b;
bool notXY = XY != true;
bool notXnotY = x != a & y != b;


if (notXY == notXnotY) Console.WriteLine("Утвеждение истинно");
else Console.WriteLine("Утверждение ложно");
Console.WriteLine();