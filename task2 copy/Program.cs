System.Console.WriteLine("Введите два числа- ");
int Num1;

while (!int.TryParse(Console.ReadLine(), out Num1))
{
    System.Console.WriteLine("Введен некорректный символ, введите ЧИСЛО");
}

System.Console.WriteLine($"Число {Num1} удовлетворяет критериям");

int Num2;
while (!int.TryParse(Console.ReadLine(), out Num2))
{
    System.Console.WriteLine("Введен некорректный символ, введите ЧИСЛО");
}

System.Console.WriteLine($"Число {Num2} удовлетворяет критериям");


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