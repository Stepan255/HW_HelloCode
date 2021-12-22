// TODO В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
Console.Clear();
Console.WriteLine("В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита");

Console.Write("Введите длинну слова: n = "); 
int namberN = Convert.ToInt32(Console.ReadLine());
string lettersInTheAlphabet = "аисв";
// int lengthOfarray = Convert.ToInt32(Math.Pow(arrayOfChar.length, namberN));
//string[] allWords = new string[];

void PrintABC(string word, string alphabet, int length)
{
	if (length < 1)
	{
		Console.WriteLine(word);
		return;
	}
	foreach (var character in alphabet)
	{
		Console.WriteLine($"/{word}/|{character}|");
		PrintABC(word + character, alphabet, length - 1);
	}
}

PrintABC("", lettersInTheAlphabet, namberN);