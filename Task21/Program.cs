// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координаты точки x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    int cat1 = xa - xb;
    int cat2 = ya - yb;
    int cat3 = za - zb;
    double result = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
    return result;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {dRound}");