/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] RandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowMyArray(int [] array)
{
    Console.WriteLine("Array is: ");
    
    for(int i = 0; i < array.Length; i ++)
    {
        Console.WriteLine(array[i] + " ");
        
    }
    Console.WriteLine();
}

int CountOdd(int[] numbers)
{   
    int count = 0;
    for(int i = 0; i < numbers.Length; i++) // пока индекс нулевой, меньше длины массива, прибавляем
    {
        if(numbers[i]%2 != 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Input size of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 1000;

int [] ThreeDigitArray = RandomArray(size, minValue, maxValue);
ShowMyArray(ThreeDigitArray);
Console.WriteLine($"The sum of odd Three digit numbers in array is {CountOdd(ThreeDigitArray)}");
