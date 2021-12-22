Console.Clear();
Console.WriteLine("Задать номер четверти, показать диапазоны для возможных координат");
Console.Write("Введите номер четверти (1, 2, 3, 4): "); 
int quarterNamber = int.Parse(Console.ReadLine());

switch(quarterNamber) {
case 1:
	Console.WriteLine("x > 0; y > 0");
	break;
case 2:
	Console.WriteLine("x < 0; y > 0");
	break;
case 3:
	Console.WriteLine("x < 0; y < 0");
	break;
case 4:
	Console.WriteLine("x > 0; y < 0");
	break;
default:
	Console.WriteLine("Неверный номер четверти");
	break;
}