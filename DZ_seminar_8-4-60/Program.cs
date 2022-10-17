/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

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

int[,,] Get3DArray(int minValue, int maxValue)
{
    int[,,] matrix = new int[2, 2, 2];
    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 2; j++)
            for (int k = 0; k < 2; k++)
            {
                matrix[i, j, k] = new Random().Next(minValue, maxValue);
            }
    return matrix;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            Console.WriteLine();
        }
    }
}


int min = getNumberFromUser("Задайте максимальное значение диапазона случайных чисел генерируемого массива: ");
int max = getNumberFromUser("Задайте минимальное значение диапазона случайных чисел генерируемого массива: ");
int[,,] res = Get3DArray(min, max);
PrintArray(res);
