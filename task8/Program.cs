﻿System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("___");
int line = 0;
while (line < num)
{
    Console.WriteLine($"{line + 2}");
    line = line + 2;
}