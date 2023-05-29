//Задача 1.
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int length, int min, int max)
{
    int[] myArray = new int[length];
    
    for (int i = 0; i < length; i++)
         myArray[i] = new Random().Next(min, max);
    return myArray;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write (array[i] + " ");
    Console.WriteLine(" ");
}

void EvenNumbersArray(int[] evenArray)
{
     int count = 0;
     for (int i = 0; i < evenArray.Length; i++)       
        if (evenArray[i] % 2 == 0)
                count++;
    Console.WriteLine($"Количество четных чисел равно {count}");
}

int lengthArray = 8;
int minVal = 100;
int maxVal = 999;

int[] myArray1 = CreateRandomArray(lengthArray, minVal, maxVal);
PrintArray(myArray1);
EvenNumbersArray(myArray1);
*/


// Задача 2.
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateArray(int length, int min, int max)
{
    int [] myArray = new int [length];
    for (int i = 0; i < length; i++)
    {
        myArray[i] = new Random().Next(min, max);
    }
    return myArray;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array[i] + " ");
    Console.WriteLine(" ");
}

int GetSumOddNumbers(int[] givenArray)
{
    int sum = 0;   
    int i = 1;      
    while (i < givenArray.Length)
    {
        sum += givenArray[i];
        i += 2;
    }
    return sum;
}

int lengthArray = 5;
int minVal = 2;
int maxVal = 100;

int[] myArray2 = CreateArray(lengthArray, minVal, maxVal);
PrintArray(myArray2);
int oddSumCount = GetSumOddNumbers(myArray2);

Console.Write($"Сумма элементов на нечетных позициях равна {oddSumCount}");
Console.WriteLine("\n");
*/

// Задача 3.
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива

Console.WriteLine("Введите длину массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];

FillArrayRandomNumbers(number);
Console.WriteLine("Массив: ");
PrintArray(number);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        {
            max = number[a];
        }
    if (number[a] < min)
        {
            min = number[a];
        }
}

Console.WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

