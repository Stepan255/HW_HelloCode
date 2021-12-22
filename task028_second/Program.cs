// TODO Подсчитать сумму цифр в числе
Console.WriteLine("Подсчитать сумму цифр в числе");
Console.Write("Введдите число: ");
double namber = Convert.ToDouble(Console.ReadLine());

namber = Math.Abs(namber);
while (namber % 1 > 0)
{
	Console.WriteLine($" 1.{namber}");
	namber *= 10;
	Console.WriteLine($" 2.{namber}");
}
Console.WriteLine($" {namber}");

double sum = 0;
while(namber > 0)
{
	sum += namber % 10;
	namber = namber / 10 - namber / 10 % 1;
}

Console.WriteLine($"Сумма цифр: {sum}");