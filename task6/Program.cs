System.Console.WriteLine("Введите число- ");
int Num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

if (Num%2 == 0) System.Console.WriteLine($"{Num} - четное число");
else
{
    System.Console.WriteLine($"{Num} - нечетное число");
}