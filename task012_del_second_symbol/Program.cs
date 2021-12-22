Console.Clear();
Console.WriteLine($"Удаляет вторую цифру трёхзначного числа");
Console.Write("Введите трехзначное целое число N = "); 
int namberN = int.Parse(Console.ReadLine());

if ((namberN % 1000 >= 100 || namberN % 1000 <= -100) && namberN / 1000 == 0)
{
	string namberNString = Convert.ToString(namberN / 100) + Convert.ToString(namberN % 10);
	int namberResalt = int.Parse(namberNString);
	Console.WriteLine($"Полученное число из {namberN} равно: {namberResalt}");
}else
{
	Console.WriteLine($"Вы ввели некоректное число: {namberN}");
}