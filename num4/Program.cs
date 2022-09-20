Console.Clear();
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int num = 1;

while (num <= number)
{
    if (num % 2 == 0)
    {
        Console.Write($"{num},");
    }
num++;
}
