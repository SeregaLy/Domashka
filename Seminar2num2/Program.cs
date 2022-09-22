Console.Clear();
Console.WriteLine("Введите число");
string number = Console.ReadLine();
int lenght = number.Length;
if (lenght > 3) 
{
    Console.Write(Convert.ToInt32(number) / 100 % 10);  
}
else 
{ 
    Console.Write("третьей цифры нет");
}
