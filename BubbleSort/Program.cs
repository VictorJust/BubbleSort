using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 5, 1, 4, 2, 8, 7, 10, 9 };
        BubbleSort(arr);
        Console.WriteLine("Sorted array");
        foreach (int i in arr)
            Console.Write(i + " ");
    }
    private static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }
}