/*Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

- возрастания
- элементы, больше 8
- знакочередования*/

Console.WriteLine();
Console.WriteLine("I. Создаём числовой массив A заполненный числами из отрезка [-10, 10].");
Console.WriteLine();
Console.Write("Массив А : ");

int length = 10;
int[] ArrayA = new int[length];
int index = 0;
int minValue = -10;
int maxValue = 10;
while (index < length)
{
    ArrayA[index] = new Random().Next(minValue, maxValue);
    Console.Write($"{ArrayA[index]} ");
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Создаём на его основе масив B, отбрасывая те элементы, которые");
Console.WriteLine();
Console.WriteLine("1. нарушают порядок возрастания,");
Console.WriteLine();

index = 1;
int temp = ArrayA[0];
Console.Write($"Массив В.1 : {temp} ");
while(index < length)
{
    if(ArrayA[index] > temp)
    {
        Console.Write($"{ArrayA[index]} ");
        temp = ArrayA[index];
    }
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("2. больше 8,");
Console.WriteLine();

index = 0;
Console.Write("Массив В.2 : ");
while(index < length)
{
    if(ArrayA[index] < 8)
    {
        Console.Write($"{ArrayA[index]} ");
    }
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("3. нарушают порядок знакочередования, ");
Console.WriteLine();

index = 1;
int count = 0;
temp = ArrayA[count];
int step = 0;
int temp2 = ArrayA[step];
Console.Write($"Массив В.3 : {temp} ");
while(index < length)
{
    if(temp > 0)
    {
        if(ArrayA[index] < 0);
        {
            Console.Write($"{ArrayA[index]} ");
        }
        temp = ArrayA[count + 2];
    }
    index = index + 2;
    if(temp2 < 0)
    {
        if(ArrayA[index] < 0);
        {
            Console.Write($"{ArrayA[index]} ");
        }
        temp2 = ArrayA[step + 2];
    }
    index = index + 2;
    
}
Console.WriteLine();

