Console.Clear();
Console.WriteLine("Данной программой решается функция y=f(a), где f(a)=2*a*a");

void NameFunction()
{
	Console.Write("Введите значение a: "); 
	int namberA = int.Parse(Console.ReadLine());
	int namberY = 2 * namberA * namberA;
	Console.WriteLine($"y = 2 * {namberA} * {namberA} = {namberY}");
}



NameFunction();

