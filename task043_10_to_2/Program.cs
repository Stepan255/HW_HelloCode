// todo Написать программу преобразования десятичного числа в двоичное
Console.Clear();
Console.WriteLine("Преобразование десятичного числа в двоичное");
Console.Write("Введите десятичное натуральное число: ");
int namber10 = int.Parse(Console.ReadLine());
int saveNamber10 = namber10;
string namberContraryOf2 = String.Empty;
while (namber10 > 0)
{
	namberContraryOf2 = namberContraryOf2 + $"{namber10 % 2}";
	namber10 /= 2;
}
string namber2 = String.Empty;
for (int i = namberContraryOf2.Length - 1; i >= 0; i--)
{
	namber2 += $"{namberContraryOf2[i]}";
}

Console.Write($"в десятичной {saveNamber10} = в двоичной {namber2}");