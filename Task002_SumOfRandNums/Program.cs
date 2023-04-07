//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int Length(string arg)
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

int MinMax(string arg)
{
    int num;
    System.Console.Write($"Enter {arg}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        System.Console.WriteLine("It's not a number!");
        System.Console.Write($"Enter {arg}: ");
    }
    return num;
}

int[] CreateArray(int length, int min, int max)
{
    int[] nums = new int [length];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(min, max + 1);
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

int SumOdd(int[] nums)
{   
    int count = 0;
    for (int i = 1; i < nums.Length; i += 2)
    {    
        count += nums[i];   
    }
    return count;
}

int length = Length("the length of array");
int min = MinMax("min num in array");
int max = MinMax("max num of length");

int [] numb = CreateArray(length, min, max);
PrintArray(numb);
System.Console.WriteLine($"Sum of elements with odd indices = {SumOdd(numb)}");

