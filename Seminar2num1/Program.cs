Console.Clear();
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

int twoNum = number % 10 % 10;

Console.Write(twoNum);

