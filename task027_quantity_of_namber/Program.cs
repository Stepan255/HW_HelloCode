Console.Clear();
Console.WriteLine("Определить количество цифр в числе");
Console.Write("Введите число A = "); 
string namberA = Console.ReadLine();

int quantityOfNamber = 0;

for (int i = 0; i < namberA.Length; i++)
{
	string namber = namberA[i].ToString();
	if (namber == "0" || namber == "1" || namber == "2" || namber == "3" || namber == "4" || namber == "5" || namber == "6" || namber == "7" || namber == "8" || namber == "9")
	{
		quantityOfNamber += 1;
	}
}

Console.WriteLine($"Количество цифр в числе = {quantityOfNamber}");