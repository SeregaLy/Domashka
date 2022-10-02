const int START = 1;
const int END = 99;
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
int[] rundomArray(int length, int start, int end)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(start, end + 1);
    }
    return resultArray;
}
void printNum(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int lengthArray = getNumFromUser("Введите длинну массива: ");
int[] newRundomArray = rundomArray(lengthArray, START, END);
printNum(newRundomArray);