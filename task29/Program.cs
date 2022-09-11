Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int number3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int number4 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int number5 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int number6 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int number7 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int number8 = int.Parse(Console.ReadLine());

int[] array = { number1, number2, number3, number4, number5, number6, number7, number8 };

Random rand = new Random();

for (int i = 8 - 1; i >= 1; i--)
{
    int j = rand.Next(i + 1);

    int tmp = array[j];
    array[j] = array[i];
    array[i] = tmp;
}

Console.WriteLine($"[{string.Join(", ", array)}]");
