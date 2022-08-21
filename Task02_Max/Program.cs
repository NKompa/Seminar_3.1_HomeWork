// Напишите программу, которая на вход принимает три числа и выдаёт, какое максимальное число.

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2 && number1 > number3)
{
    Console.Write("Max = ");
    Console.WriteLine(number1);
}
else if(number2 > number1 && number2 > number3)
{
    Console.Write("Max = ");
    Console.WriteLine(number2);
}
else if(number3 > number1 && number3 > number2)
{
    Console.Write("Max = ");
    Console.WriteLine(number3);
}
else
{
    Console.Write("Числа равны");
}