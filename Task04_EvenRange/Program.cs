// Напишите программу, которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 2;
while(number1<=number)
{
    Console.WriteLine(number1);
    number1=number1+2;
}
int number2 = -2;
while(number2>=number)
{
    Console.WriteLine(number2);
    number2=number2-2;
}
if(number==0 || number==1 || number==-1)
{
    Console.WriteLine("Нет чётных чисел");
}