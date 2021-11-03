/*Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
Создать на его основе масив B, отбрасывая те элементы, которые

1. нарушают порядок возрастания
2. больше среднего арифметического элементов A
3. чётные*/

/*Console.WriteLine();
Console.WriteLine();
Console.WriteLine("II. Создаём целочисленный массив A из натуральных двузначных чисел.");
Console.WriteLine();
Console.Write("Массив А : ");

int length = 10;
int[] A = new int[length];
int index = 0;
while (index < length)
{
    A[index] = new Random().Next(10, 100);
    Console.Write($"{A[index]} ");
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Создаём на его основе масив B, отбрасывая те элементы, которые");
Console.WriteLine();
Console.WriteLine("1. нарушают порядок возрастания,");
Console.WriteLine();

index = 1;
int temp = A[0];
Console.Write($"Массив В.1 : {temp} ");
while(index < length)
{
    if(A[index] > temp)
    {
        Console.Write($"{A[index]} ");
        temp = A[index];
    }
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("2. больше среднего арифметического элементов A,");
Console.WriteLine();

double midA = 0;
index = 0;
while(index < length)
{
    midA = midA + A[index];
    index++;
}
midA = midA / length;
Console.WriteLine($"Среднее арифметическое элементов массива А = {midA}");
Console.WriteLine();

index = 0;
Console.Write("Массив В.2 : ");
while(index < length)
{
    if(A[index] < midA)
    {
        Console.Write($"{A[index]} ");
    }
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("3. чётные.");
Console.WriteLine();

index = 0;
Console.Write("Массив В.3 : ");
while(index < length)
{
    if(A[index]%2 == 0)
    {
        Console.Write($"{A[index]} ");
    }
    index++;
}
Console.WriteLine();
Console.WriteLine();
*/

int[] CreateArrayA(int[] Array, int min, int max)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(min, max);
        Console.Write($"{Array[index]} ");
        index++;
    }
    return Array;
}

//II. Создаём целочисленный массив A из натуральных двузначных чисел.
int length = 10;
int[] ArrayA = new int[length]; //Массив А : 

CreateArrayA(ArrayA, 10, 100);
Console.WriteLine();

