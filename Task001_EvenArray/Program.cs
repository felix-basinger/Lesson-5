//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int Num(string arg)
{
    int num;
    System.Console.Write($"Enter {arg}: ");
    while(!int.TryParse(Console.ReadLine(), out num) || num < 1)
    {
        System.Console.WriteLine("It's not a number or incorrect data!");
        System.Console.Write($"Enter {arg}: ");
    }
    return num;
}

int[] CreateArray(int length)
{
    int[] nums = new int [length];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(100, 1000);
    }
    return nums;
}

void PrintArray(int[] nums)
{
    System.Console.Write("[");
    for (int i = 0; i < nums.Length - 1; i++)
    {
        System.Console.Write(nums[i] + "; ");
        
    }
    System.Console.WriteLine(nums[nums.Length - 1] + "]");
}

int EvenNums(int[] nums)
{   
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int length = Num("the length of array");
int [] numbs = CreateArray(length);
PrintArray(numbs);
System.Console.WriteLine($"Count of even numbers in your array = {EvenNums(numbs)}");