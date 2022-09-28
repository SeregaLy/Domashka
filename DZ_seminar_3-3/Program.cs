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

int[] calculatorCubes(int num)
{
    int[] result = new int [num];
    for(int i = 1; i <= num; i++)
    {
        result[i - 1] = (int)(Math.Pow(i, 3));
    }
    return result;
}

int N = getNumFromUser("Введите целое число больше единицы: ");
int[] table = calculatorCubes(N);

for (int i = 0; i < table.Length; i++)
{
    Console.Write(table[i] + " ");
}