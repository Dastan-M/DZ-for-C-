// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

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
int countInRange = CountElementsInRange(arr, 20, 90);
Console.WriteLine($"Количество элементов массива, значение которых лежит в отрезке [20, 90]: {countInRange}");
int CountElementsInRange(int[] arr, int min, int max)
{
        int count = 0;
        foreach (int num in arr)
        {
            if (num >= min && num <= max)
            {
                count++;
            }
        }
        return count;
    }