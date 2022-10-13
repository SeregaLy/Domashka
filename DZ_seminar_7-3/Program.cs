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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
        {
        for (int j = 0; j < n; j++)
           {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
           }
        }   
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }    
        Console.WriteLine();
    }
}

void AverageColumsSum(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double result = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        result += arr[i, j];
        Console.Write($"{result/arr.GetLength(1):f1}, ");
    }
}

int m = getNumFromUser("Введите длинну массива: ");
int n = getNumFromUser("Введите ширину массива: ");
int minValue = getNumberFromUser("Введите минимальное значение элемента массива: ");
int maxValue = getNumberFromUser("Введите максимальное значение элемента массива: ");

int[,] myArray = GetArray(m, n, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine();
AverageColumsSum(myArray);