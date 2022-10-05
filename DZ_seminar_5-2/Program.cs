const int START = -99;
const int END = 99;

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

int sumElements(int[] currentArray)
{
    int result = 0;
    for (int i = 1; i < currentArray.Length; i += 2)
    {
        result += currentArray[i];
    }
    return result;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] currentArray = getRandomArray(length, START, END);
printArray(currentArray);

int sumElement = sumElements(currentArray);
Console.WriteLine($"Сумма элементов на нечетных позициях = {sumElement}");