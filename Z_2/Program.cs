//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Lenght(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    return Math.Round(Math.Sqrt(((X1 - X2) * (X1 - X2)) + ((Y1 - Y2) * (Y1 - Y2)) + ((Z1 - Z2) * (Z1 - Z2))), 2);
    
}
Console.Write("Расстояние между заданными точками: ");
Console.Write(Lenght(x1, y1, z1, x2, y2, z2));