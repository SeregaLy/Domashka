/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
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

int[,] ProductMatrix(int[,] matrix, int[,] matrix1, int m, int n)
{
    int[,] res_matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                res_matrix[i, j] += matrix[i, k] * matrix1[k, j];
            }
    }
    return res_matrix;
}

int m = getNumFromUser("Введите колличество строк генерируемого массива: ");
int n = getNumFromUser("Введите колличество столбцов генерируемого массива: ");
int min = getNumberFromUser("Задайте максимальное значение диапазона случайных чисел генерируемого массива: ");
int max = getNumberFromUser("Задайте минимальное значение диапазона случайных чисел генерируемого массива: ");
int[,] res = GetArray(m, n, min, max);
int[,] res1 = GetArray(m, n, min, max);
Console.WriteLine("Первая матрица:");
PrintArray(res);
Console.WriteLine("Вторая матрица:");
PrintArray(res1);
int[,] res_matrix = ProductMatrix(res, res1, m, n);
Console.WriteLine("Произведение двух матриц:");
PrintArray(res_matrix);