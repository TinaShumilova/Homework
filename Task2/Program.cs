/*Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

- возрастания
- элементы, больше 8
- знакочередования*/

int[] CreateArrayA(int[] Array, int min, int max)
{
    int index = 0;
    while (index < Array.Length)
    {
        Array[index] = new Random().Next(min, max + 1);
        Console.Write($"{Array[index]} ");
        index++;
    }
    return Array;
}

int[] CreateArrayB1(int[] ArrayA)
{
    int[] ArrayB = new int[ArrayA.Length];
    int indA = 1;
    int indB = 1;
    ArrayB[0] = ArrayA[0];
    int temp = ArrayB[0];
    Console.Write($"Массив В.1 : {ArrayB[0]} ");
    while(indA < ArrayA.Length)
    {
        if(ArrayA[indA] > temp)
        {
            ArrayB[indB] = ArrayA[indA];
            Console.Write($"{ArrayB[indB]} ");
            temp = ArrayB[indB];
        }
        indA++;
        indB++;
    }
    return ArrayB;
}

int[] CreateArrayB2(int[] ArrA)
{
    int[] ArrB = new int[ArrA.Length];
    int indexA = 0;
    int indexB = 0;
    Console.Write("Массив В.2 : ");
    while(indexA < ArrA.Length)
    {
        if(ArrA[indexA] < 8)
        {
            ArrB[indexB] = ArrA[indexA];
            Console.Write($"{ArrB[indexB]} ");
        }
        indexA++;
        indexB++;
    }
    return ArrB;
}

int[] CreateArrayB3(int[] A)
{
    int[] B = new int[A.Length];
    int iA = 1;
    int iB = 1;
    B[0] = A[0];
    int temp = A[0];
    Console.Write($"Массив В.3 : {B[0]} ");
    while(iA < A.Length)
    {
        if((temp > 0) && (A[iA] < 0) || (temp < 0) && (A[iA] > 0)) 
        {
            B[iB] = A[iA];
            Console.Write($"{B[iB]} ");
            temp = A[iA];
        }
        iA++;
        iB++;
    }
    return B;
}

Console.WriteLine();
Console.WriteLine("Создаём числовой массив A заполненный числами из отрезка [-100, 100].");
Console.Write("Массив А : ");

int[] ArrayA = new int[10];
int minValue = -100;
int maxValue = 100;

CreateArrayA(ArrayA, minValue, maxValue);
Console.WriteLine();

Console.WriteLine("Создаём на его основе масив B, отбрасывая те элементы, которые");
Console.WriteLine("1. нарушают порядок возрастания,");

int[] ArrayB1 = CreateArrayB1(ArrayA);
Console.WriteLine();

Console.WriteLine("2. больше 8,");

int[] ArrayB2 = CreateArrayB2(ArrayA);
Console.WriteLine();

Console.WriteLine("3. нарушают порядок знакочередования, ");

int[] ArrayB3 = CreateArrayB3(ArrayA);
Console.WriteLine();