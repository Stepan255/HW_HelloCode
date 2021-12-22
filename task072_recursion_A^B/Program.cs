// TODO Написать программу возведения числа А в целую стень B
Console.Clear();
Console.WriteLine("Написать программу возведения числа А в целую стень B");

Console.Write("Введите неотрицательное целое число A = "); 
double namberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите неотрицательное целое число B = "); 
int namberB = Convert.ToInt32(Console.ReadLine());

double AInBDegree(double namber, int degree)
{
	if (degree == 1) return namber;
	else
		return namber * AInBDegree(namber, degree - 1);
}

Console.WriteLine($"A^B = {AInBDegree(namberA, namberB)}"); 