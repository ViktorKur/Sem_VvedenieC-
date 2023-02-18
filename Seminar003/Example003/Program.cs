// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите координаты x точки А: ");

int[] coordsA = new int[2];

coordsA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты y точки A: ");

coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты x точки B: ");

int[] coordsB = new int[2];

coordsB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты y точки B: ");

coordsB[1] = Convert.ToInt32(Console.ReadLine());

int distanceX = (int) Math.Pow(coordsB[0]-coordsA[0], 2);
int distanceY = (int) Math.Pow(coordsB[1]-coordsA[1], 2);

double Result = Math.Sqrt (distanceX+distanceY);

System.Console.WriteLine(Math.Round(Result,2));