double getNumFromUser(string userInformation)
{
    double result = 0;
    Console.Write($"{userInformation} ");
    while (!double.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается число. {userInformation} ");
    }
    return result;
}

void CrossPoint(double k1, double k2, double b1, double b2)
{
    double y = 0;
    double x = 0;
    if ((k1 != k2) && (b1 != b2))
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точкой пересечения прямых является точка с координатами: ({y}; {x})");
    }
    else
        { 
           Console.WriteLine($"Прямые не пересекаются");
        }
}

double k1 = getNumFromUser("Введите значение к1: ");
double k2 = getNumFromUser("Введите значение к2: ");
double b1 = getNumFromUser("Введите значение b1: ");
double b2 = getNumFromUser("Введите значение b2: ");
CrossPoint(k1, k2, b1, b2);