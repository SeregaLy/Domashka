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

string checkNumber(int num)
{
if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
    {
        return "Да";
    }
else
    {
        return "Нет";
    }
}
int num = getNumFromUser("Введите пятизначное число");
Console.Write(checkNumber(num));