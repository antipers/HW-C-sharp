System.Console.WriteLine("Введите два числа- ");
//int Num1 = Convert.ToInt32(Console.ReadLine());
//int Num2 = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine();
string string1 = Console.ReadLine();
int Num1;
if (int.TryParse(string1, out Num1))
{
    System.Console.WriteLine($"Число {Num1} удовлетворяет критериям");
}
else
{
    System.Console.WriteLine("Введите ЧИСЛО");
}
string string2 = Console.ReadLine();
int Num2;
if (int.TryParse(string2, out Num2))
{
    System.Console.WriteLine($"Число {Num2} удовлетворяет критериям");
}
else
{
    System.Console.WriteLine("Введите ЧИСЛО");
}

if (Num2 > Num1)
{
    System.Console.WriteLine($"Число {Num2} больше, чем число {Num1}");
}
else if (Num1 > Num2)
{
    System.Console.WriteLine($"Число {Num1}  больше, чем число {Num2}");
}
else
{
    System.Console.WriteLine($"Число {Num1} равно числу {Num2}");
}