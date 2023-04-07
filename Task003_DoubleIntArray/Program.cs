//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

double[] CreateArray(int length)
{
    int count = 0;
    double [] nums = new double [length];
    for (int i = 0; i < nums.Length; i++)
    {   
        count++;
        System.Console.Write($"Enter the {count} element of array: ");
        while(!double.TryParse(Console.ReadLine(), out nums[i]))
        {
            System.Console.WriteLine("It's not a number!");
            System.Console.Write($"Enter the {count} element of array: ");
        }
    }
    return nums;
}

void PrintArray(double[] nums)
{
    System.Console.Write("[");
    for (int i = 0; i < nums.Length - 1; i++)
    {
        System.Console.Write(nums[i] + "; ");
    }
    System.Console.WriteLine(nums[nums.Length - 1] + "]");
}

double Max(double[] nums)
{
    double max = nums[0];
    for (int i = 0; i < nums.Length; i++)
    {
        if(max < nums[i])
        {
            max = nums[i];
        }
    }
    return max;
}

double Min(double[] nums)
{
    double min = nums[0];
    for (int i = 0; i < nums.Length; i++)
    {
        if(min > nums[i])
        {
            min = nums[i];
        }
    }
    return min;
}

double Diff(double a, double b)
{
    double result = a - b;
    return result;
}

int length = Length("the length of array");
double [] numb = CreateArray(length);
PrintArray(numb);
System.Console.WriteLine($"The biggest number in your array = {Max(numb)}");
System.Console.WriteLine($"The smallest number in your array = {Min(numb)}");
System.Console.WriteLine($"The difference between the biggest and the smallest elements = {Diff(Max(numb), Min(numb))}");