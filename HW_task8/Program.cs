// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Pls, input number:");
int num = Convert.ToInt32(Console.ReadLine());

int EvenNum = 2;

while (EvenNum <= num)
{
    Console.Write($"{EvenNum}, ");
    EvenNum = EvenNum +2;
}
Console.WriteLine("А как по-нормальному сделать так, чтобы по окончании вывода Console.Write курсор вставал с НОВОЙ СТРОКИ?");