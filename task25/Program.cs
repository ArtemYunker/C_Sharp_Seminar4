// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.WriteLine("Введите число A");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int number2 = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 0; i < number2; i++)
{
    result = result * number1;
}

Console.WriteLine(result);