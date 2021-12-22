// TODO Найти сумму цифр числа
Console.Clear();
Console.WriteLine("Найти сумму цифр числа");

void SumOfSymbol(string namberA, int count, int sum)
{
	if (count < namberA.Length)
	{
		string namber = namberA[count].ToString();
		if (namber == "0" || namber == "1" || namber == "2" || namber == "3" || namber == "4" || namber == "5" || namber == "6" || namber == "7" || namber == "8" || namber == "9") 
			sum += int.Parse(namber);
		count +=1;
		SumOfSymbol(namberA, count, sum);
	}else
		Console.WriteLine($"Сумма цифр в числе = {sum}");
}

Console.Write("Введите число A = "); 
string namberA = Console.ReadLine();

int sum = 0;
int count = 0;
SumOfSymbol(namberA, count, sum);