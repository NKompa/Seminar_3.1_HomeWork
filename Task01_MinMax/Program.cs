// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.Write("Max = ");
    Console.WriteLine(number1);
    Console.Write("Min = ");
    Console.WriteLine(number2);
}
else if(number1 < number2)
{
    Console.Write("Max = ");
    Console.WriteLine(number2);
    Console.Write("Min = ");
    Console.WriteLine(number1);
}
else
{
    Console.Write("Числа равны");
}