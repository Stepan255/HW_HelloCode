Console.Clear();
Console.Write("Введите номер дня недели (Понедельник первый день недели): ");
int day_of_week = int.Parse(Console.ReadLine());
switch(day_of_week) {
case 1:
	Console.WriteLine("Понедельник");
	break;
case 2:
	Console.WriteLine("Вторник");
	break;
case 3:
	Console.WriteLine("Среда");
	break;
case 4:
	Console.WriteLine("Четверг");
	break;
case 5:
	Console.WriteLine("Пятница");
	break;
case 6:
	Console.WriteLine("Суббота");
	break;
case 7:
	Console.WriteLine("Воскресенье");
	break;
default:
	Console.WriteLine("Что-то пошло не так");
	break;
}