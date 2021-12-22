Console.Clear();
Console.WriteLine("Подсчитать сумму цифр в числе");
Console.Write("Введите число A = "); 
string namberString = Console.ReadLine();
double namber1 = Convert.ToDouble(namberString);

int sum = 0;
for (int i = 0; i < namberString.Length; i++)
{
	string namber = namberString[i].ToString();
	if (namber == "0" || namber == "1" || namber == "2" || namber == "3" || namber == "4" || namber == "5" || namber == "6" || namber == "7" || namber == "8" || namber == "9")
	{
		sum += Convert.ToInt32(namber);
	}
}

Console.WriteLine($"Сумма цифр в числе = {sum}");