// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число B");
int number = int.Parse(Console.ReadLine());

int sum = 0;
while (number > 0)
{
    int digit = number % 10; 
    sum = digit + sum;
    number = number / 10;   

}
Console.WriteLine(sum);