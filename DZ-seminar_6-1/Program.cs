int[] GetArray(int M)
{
    int[] res = new int[M];
    for (int i = 0; i < M; i++)
    {
        int result = 0;
        Console.Write("Введите значение элемента массива: ");
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write($"Ошибка ввода! Ожидается целое число.");
        }
        res[i] = result;
    }
    return res;
}

int PositiveSum(int[] mike)
{
   int result = 0; 
   for (int i = 0; i < mike.Length; i++)
   if(mike[i] > 0)
   {
      result++;
   }
   return result;
}

Console.Write("Введите количество элементов массива M: ");
int M = int.Parse(Console.ReadLine());

int[] arrCost =  GetArray( M);
Console.WriteLine($"Вы ввели массив: [{String.Join(",", arrCost)}]");
Console.WriteLine($"Колличество элементов массива больше нуля составляет: {PositiveSum(arrCost)}"); 