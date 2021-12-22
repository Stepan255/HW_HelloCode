

Console.Write("Введите число: ");
double namberN = double.Parse(Console.ReadLine());

while (namberN * 10 % 10 == 0)
{
	namberN *= 10;
}

Console.WriteLine(namberN);