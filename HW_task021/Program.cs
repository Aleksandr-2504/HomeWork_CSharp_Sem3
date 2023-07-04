/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();
Console.Write("Введите координату первой точки по оси (x): ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по оси (y): ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по оси (z): ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по оси (x): ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по оси (y): ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по оси (z): ");
int z2 = Convert.ToInt32(Console.ReadLine());
//1 способ уменьшения количества знаков после запятой: 
double S = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
Console.Write($"Расстояние между двумя точками в 3D пространстве: S = {S}");
//2 способ уменьшения количества знаков после запятой: 
//double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
//Console.Write($"Расстояние между двумя точками в 3D пространстве: S = {S:f2}");