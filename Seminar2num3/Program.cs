Console.Clear();
string[] weekDays = new string[] { "нет", "нет", "нет", "нет", "нет", "да", "да" };
Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine()); 
Console.Write(weekDays[number - 1]);

