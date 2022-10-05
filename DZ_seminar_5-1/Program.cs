const int START = 100;
const int END = 999;

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}

void printArray(int[] incomingArray)
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

int evenNumbersInArray(int[] currentArray)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] currentArray = getRandomArray(length, START, END);
printArray(currentArray);

int evenNumbers = evenNumbersInArray(currentArray);
Console.WriteLine($"Количество четных чисел в массиве = {evenNumbers}");