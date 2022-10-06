// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве
//A(3,6);B(2,1) -> 5,09
//A(7,-5);B(1,-1) -> 7,21
Console.Clear();

Console.Write("Введите координаты Х для А: ");
double xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Y для А: ");
double ya = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты Х для B: ");
double xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Y для B: ");
double yb = double.Parse(Console.ReadLine()!);

double d = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
//d = Math(d, 2);
//Console.Write($"длина отрезка = {d:f2}");

Console.WriteLine(d.ToString("#.000"));