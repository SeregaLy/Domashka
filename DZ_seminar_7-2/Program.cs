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

int[,] GetArray(int row, int col, int beginNum, int endNum)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            result[i, j] = new Random().Next(beginNum, endNum + 1);

    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ElementPosition(int[,] arr, int m, int n)
{
    
    if (m > arr.GetLength(0) || n > arr.GetLength(1))
    {
        Console.WriteLine($"Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"{arr[m, n]}");
    }

}
int row = getNumFromUser("Введите длинну массива: ");
int col = getNumFromUser("Введите ширину массива: ");
int beginNum = getNumberFromUser("Введите минимальное значение элемента массива: ");
int endNum = getNumberFromUser("Введите максимальное значение элемента массива: ");
int m = getNumberFromUser("Введите i искомого элемента массива: ");
int n = getNumberFromUser("Введите j искомого элемента массива: ");

int[,] myArray = GetArray(row, col, beginNum, endNum);
PrintArray(myArray);
Console.WriteLine();
ElementPosition(myArray, m, n);