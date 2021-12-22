Console.Clear();
Console.WriteLine("Найти расстояние между точками A и B в пространстве 3D");

int rangeMin = -1000;
int rangeMax = 1000;
int[] pointA = new int[3];
int[] pointB = new int[3];
void NewPoint(int[] point)
{
	point[0] = new Random().Next(rangeMin, rangeMax);
	Console.WriteLine($"A ({point[0]}, {pointA[0]}, {pointB[0]})");
	point[1] = new Random().Next(rangeMin, rangeMax);
	point[2] = new Random().Next(rangeMin, rangeMax);
}


NewPoint(pointA);
NewPoint(pointB); 

Console.WriteLine($"A ({pointA[0]}, {pointA[1]}, {pointA[2]})");
Console.WriteLine($"B ({pointB[0]}, {pointB[1]}, {pointB[2]})");

double distance = Math.Round(Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2)), 2);
Console.WriteLine($"Расстояние между точками A и B равно {distance}");