//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Pls, input first number:");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Pls, input second number:");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Pls, input third number:");
double num3 = Convert.ToDouble(Console.ReadLine());

double max = 0;

if (num1 == num2 && num2 == num3)
    Console.WriteLine($"this numbers equal");
else
{
    if (num1 > num2)
        max = num1;
    else
        max = num2;
    if (max < num3)
        max = num3; 
    Console.WriteLine($"Max = {max}");
}