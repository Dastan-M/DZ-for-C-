// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * 100;
    }
}
double[] arr = new double[5];
FillArray(arr);
System.Console.WriteLine(string.Join("\t", arr));


double dif = FindDifference(arr);

double FindDifference(double[] arr){

double min = arr[0];
double max = arr[0];

foreach (double num in arr)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }
double dif = max - min;
return dif;
}
Console.WriteLine($"разницу между максимальным и минимальным элементов массива: {dif}");