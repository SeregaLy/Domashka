/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

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

int SumTwoNum(int M, int N)
{
    if (N == M)
        {
        return M;
    }
    return N + SumTwoNum(M, --N);
    
}

int numberM = getNumberFromUser("Задайте значение М: ");
int numberN = getNumberFromUser("Задайте значение N: ");
int result = SumTwoNum(numberM,numberN);
System.Console.WriteLine(result);