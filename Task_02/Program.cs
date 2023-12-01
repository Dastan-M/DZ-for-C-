// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

  void FillArray(int[] arr)
{
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 101);
    }
}
int[] arr = new int [10];
FillArray(arr);
System.Console.WriteLine(string.Join(",", arr));

int countElements = CountEvenElements(arr);
Console.WriteLine($"Количество чётных чисел в массиве: {countElements}");
int CountEvenElements(int[] arr)
{
        int count = 0;
        foreach (int num in arr)
        {
            if (num%2==0)
            {
                count++;
            }
        }
        return count;
    }