//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArray (int size, int maxValue, int minValue)
{
    int [] array = new int [size];

    for(int i = 0; i < size; i ++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;     
}

void ShowMyArray(int[] array)
{
    Console.Write("Array is: ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfOdd(int[] numbers)
{
    int sum = 0;
    for(int i = 0; i < numbers.Length; i ++)
    {
        if(i%2 == 0)
        {
            sum = sum + numbers[i];
        }
    }
    return sum;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max value of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min value of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

int [] MyArray = CreateRandomArray(size, maxValue, minValue);
ShowMyArray(MyArray);
Console.WriteLine($"Sum of unodd elements is: {SumOfOdd(MyArray)}: ");
