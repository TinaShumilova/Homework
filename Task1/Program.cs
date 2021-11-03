/*Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
Создать на его основе масив B, отбрасывая те элементы, которые

1. нарушают порядок возрастания
2. больше среднего арифметического элементов A
3. чётные*/

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

int[] CreateArrayB1(int[] A)
{
    int len = A.Length;
    int[] B = new int[len];
    int indA = 1;
    int indB = 1;
    B[0] = A[0];
    int temp = B[0];
    Console.Write($"Массив В.1 : {B[0]} ");
    while(indA < len)
    {
        if(A[indA] > temp)
        {
            B[indB] = A[indA];
            Console.Write($"{B[indB]} ");
            temp = B[indB];
        }
        indA++;
        indB++;
    }
    return B;
}

double midA(int[] arrA)
{
    double middle = 0;
    int leng = arrA.Length;
    int i = 0;
    while(i < leng)
    {
        middle = middle + arrA[i];
        i++;
    }
    middle = middle / leng;
    return middle;
}

int[] CreateArrayB2(int[] arA)
{
    int lengh = arA.Length;
    int[] arB = new int[lengh];
    int nA = 0; 
    int nB = 0;
    Console.Write("Массив В.2 : ");
    while(nA < lengh)
    {
        if(arA[nA] < midA(arA))
        {
            arB[nB] = arA[nA];
            Console.Write($"{arB[nB]} ");
        }
        nA++;
        nB++;
    }
    Console.WriteLine();
    return arA;
}

int[] CreateArrayB3(int[] array)
{
    int lent = array.Length;
    int[] ArrB = new int[lent];
    int inde = 0;
    int index = 0;
    Console.Write("Массив В.3 : ");
    while(inde < lent)
    {
        if(array[inde]%2 != 0)
        {
            ArrB[index] = array[inde];
            Console.Write($"{ArrB[index]} ");
        }
        inde++;
        index++;
    }
    return ArrB;
}

Console.WriteLine();
Console.WriteLine("Создаём целочисленный массив A из натуральных двузначных чисел.");
Console.Write("Массив А : ");

int length = 10;
int[] ArrayA = new int[length]; //Массив А : 

CreateArrayA(ArrayA, 10, 100);
Console.WriteLine();

Console.WriteLine("Создаём на его основе масив B, отбрасывая те элементы, которые");
Console.WriteLine("1. нарушают порядок возрастания,");


int[] ArrayB1 = CreateArrayB1(ArrayA); // Массив В.1
Console.WriteLine();

Console.WriteLine("2. больше среднего арифметического элементов A,");

Console.WriteLine($"Среднее арифметическое элементов массива А = {midA(ArrayA)}");

int[] ArrayB2 = CreateArrayB2(ArrayA); // Массив В2

Console.WriteLine("3. чётные.");

int[] ArrayB3 = CreateArrayB3(ArrayA); // Массив В3
Console.WriteLine();