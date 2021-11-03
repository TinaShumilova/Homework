/*Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

- возрастания
- элементы, больше 8
- знакочередования*/

int[] CreateArrayA(int[] Array, int min, int max)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(min, max + 1);
        Console.Write($"{Array[index]} ");
        index++;
    }
    return Array;
}

Console.WriteLine("I. Создаём числовой массив A заполненный числами из отрезка [-10, 10].");
Console.Write("Массив А : ");

int length = 10;
int[] ArrayA = new int[length];
int minValue = -10;
int maxValue = 10;

CreateArrayA(ArrayA, minValue, maxValue);

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
temp = ArrayA[0];
Console.Write($"Массив В.3 : {temp} ");
while(index < ArrayA.Length)
{
    if((temp > 0) && (ArrayA[index] < 0))
    {
        Console.Write($"{ArrayA[index]} ");
        temp = ArrayA[index];
    }
    if((temp < 0) && (ArrayA[index] > 0))
    {
        Console.Write($"{ArrayA[index]} ");
        temp = ArrayA[index];
    }
    index++;
}    
Console.WriteLine();