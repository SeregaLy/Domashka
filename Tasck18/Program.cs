string getQuarterFromCoordinate(int quarter)
{
    string coordinate = "";
    if (quarter == 1)
    {
        coordinate = "x > 0 y > 0";
    }
    else if (quarter == 2)
    {
        coordinate = "x < 0 y > 0";
    }
    else if (quarter == 3)
    {
        coordinate = "x < 0 y < 0";
    }
    else if (quarter == 4)
    {
        coordinate = "x > 0 y < 0";
    }

    return coordinate;
}
string dip;
Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter > 0 && quarter < 5)
{
    dip = getQuarterFromCoordinate(quarter);
    Console.WriteLine($"Диапазон значений {dip}");
}
else
{
    Console.WriteLine($"Неверное значение");
}