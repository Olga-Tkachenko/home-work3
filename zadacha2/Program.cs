// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
// 3D пространстве. Например: А(3,6,8) В(2,1,-7) - 15,84. А(7,-5,0) В(1,-1,9) - 11,53.
Console.WriteLine("Введите координату х1: ");
string? x1String = Console.ReadLine();
int x1 = int.Parse(x1String);
Console.WriteLine("Введите координату y1: ");
string? y1String = Console.ReadLine();
int y1 = int.Parse(y1String);
Console.WriteLine("Введите координату z1: ");
string? z1String = Console.ReadLine();
int z1 = int.Parse(z1String);
Console.WriteLine("Введите координату х2: ");
string? x2String = Console.ReadLine();
int x2 = int.Parse(x2String);
Console.WriteLine("Введите координату y2: ");
string? y2String = Console.ReadLine();
int y2 = int.Parse(y2String);
Console.WriteLine("Введите координату z2: ");
string? z2String = Console.ReadLine();
int z2 = int.Parse(z2String);
double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine("Расстояние между точками " + AB.ToString("N2"));

