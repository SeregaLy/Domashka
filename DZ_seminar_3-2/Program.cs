int getNumFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInformation} ");
    }
    return result;
}

double distancBetweenTwoPoints(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
}

int x1 = getNumFromUser("Введите координату Х для первой точки");
int y1 = getNumFromUser("Введите координату У для первой точки");
int z1 = getNumFromUser("Введите координату Z для первой точки");
int x2 = getNumFromUser("Введите координату Х для второй точки");
int y2 = getNumFromUser("Введите координату У для второй точки");
int z2 = getNumFromUser("Введите координату Z для первой точки");

Console.WriteLine(distancBetweenTwoPoints(x1, y1, z1, x2, y2, z2));