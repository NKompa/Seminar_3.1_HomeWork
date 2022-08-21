// Напишите программу, которая на вход принимает число и выдаёт, является ли оно чётным.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}