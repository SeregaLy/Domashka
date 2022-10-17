/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка*/

int getNumFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
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

void MinRow(int[,] arr)
{
    int min = 0;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int res = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res += arr[i, j];
            if (i == 0)
                sum = res;
        }
        if (res < sum)
        {
            sum = res;
            min = i;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {min} строка");
}

int m = getNumFromUser("Введите колличество строк генерируемого массива: ");
int n = getNumFromUser("Введите колличество столбцов генерируемого массива: ");
int min = getNumberFromUser("Задайте максимальное значение диапазона случайных чисел генерируемого массива: ");
int max = getNumberFromUser("Задайте минимальное значение диапазона случайных чисел генерируемого массива: ");
int[,] res = GetArray(m, n, min, max);
PrintArray(res);
Console.WriteLine();
MinRow(res);