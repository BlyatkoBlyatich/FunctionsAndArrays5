//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateRealNumbersArray (int size, int maxValue, int minValue)
{
    double[] array = new double[size];

    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = Math.Round(new Random().Next(minValue, maxValue+1) + new Random().NextDouble(), 0);
    }
    return array;     
}

void ShowMyArray(double[] array)
{
    Console.Write($"Array is: ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double NumbersDifference(double [] diff, double maxValue, double minValue) // добавили значения максимальных и минимальных чисел для устранения багов
{
    double max = minValue - 1;
    double min = maxValue + 1;
    
    for(int i = 0; i < diff.Length; i ++)
    {
        if(diff[i] > max)
        {
            max = diff [i];
        }
        if(diff[i] < min)
        {
        min = diff [i];
        }
    }
    return max - min;
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max Value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min Value: ");
int min = Convert.ToInt32(Console.ReadLine());

double[] MyArray = CreateRealNumbersArray(size, max, min);
ShowMyArray(MyArray);
Console.WriteLine($"The difference of min and max number is: {NumbersDifference(MyArray, max, min)}");
