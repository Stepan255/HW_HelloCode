Console.Clear();
Console.WriteLine("Определить номер четверти плоскости, в которой находится точка с координатами Х и Y, причем X ≠ 0 и Y ≠ 0");
Console.Write("Введите значение X: "); 
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение Y: "); 
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("1 четверть");
if (x < 0 && y > 0) Console.WriteLine("2 четверть");
if (x < 0 && y < 0) Console.WriteLine("3 четверть");
if (x > 0 && y < 0) Console.WriteLine("4 четверть");

/*
switch(x, y) {
case (> 0 , > 0):
	Console.WriteLine("1 четверть");
	break;
case (< 0, > 0):
	Console.WriteLine("2 четверть");
	break;
case (< 0, < 0):
	Console.WriteLine("3 четверть");
	break;
case (> 0, < 0):
	Console.WriteLine("4 четверть");
	break;
default:
	Console.WriteLine("Что то пошло не так");
	break;
}
*/