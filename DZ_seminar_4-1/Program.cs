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

double exponentNum(int Num1, int Num2)
{
    double result = Math. Pow(Num1, Num2);
    return result;
}

int num1 = getNumFromUser("Введите число которое будет возводиться в степень: ");
int num2 = getNumFromUser("Введите число которое будет степенью числа: ");
double ExponentNum = exponentNum(num1, num2);
Console.Write($"{ExponentNum}");