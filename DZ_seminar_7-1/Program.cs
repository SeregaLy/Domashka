int getNumFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число, больше единицы. {userInformation} ");
    }
    return result;
}
int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInformation} ");
    }
    return result;
}

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue+1)/10.0;

    return result;
}

void PrintArray(double[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        Console.Write($"{array[i,j]} ");
    Console.WriteLine();    
    }
}

int m = getNumFromUser("Введите длинну массива: ");
int n = getNumFromUser("Введите ширину массива: ");
int minValue = getNumberFromUser("Введите минимальное значение элемента массива: ");
int maxValue = getNumberFromUser("Введите максимальное значение элемента массива: ");

double[,] myArray = GetArray(m, n, minValue, maxValue);
PrintArray(myArray, m, n);