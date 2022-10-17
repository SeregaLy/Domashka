/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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

int[,] DescendRowElements(int[,]arr)
{
    for (int run = 0; run < arr.GetLength(1) - 1; run++)
    {
        int max = 0;
        for (int i = 0; i <arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) -1 ; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    max = arr[i, j + 1];
                    arr[i, j + 1] = arr[i, j];
                    arr[i, j] = max;
                }
            }
        }

    }
    return arr;
}



int m = getNumFromUser("Введите колличество строк генерируемого массива: ");
int n = getNumFromUser("Введите колличество столбцов генерируемого массива: ");

int min = getNumberFromUser("Задайте максимальное значение диапазона случайных чисел генерируемого массива: ");
int max = getNumberFromUser("Задайте минимальное значение диапазона случайных чисел генерируемого массива: ");
int[,] res = GetArray(m, n, min, max);
PrintArray(res);
Console.WriteLine();
int[,] array = DescendRowElements(res);
PrintArray(array);