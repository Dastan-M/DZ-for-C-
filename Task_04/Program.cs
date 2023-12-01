// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

System.Console.WriteLine("Задайте натуральное число в диапазоне от 1 до 100 000: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int digitCount = (int)Math.Floor(Math.Log10(number)) + 1;
int[] digits = new int[digitCount];

for (int i = digitCount - 1; i >= 0; i--)
{
    digits[i] = number % 10; 
    number /= 10; 
}
System.Console.Write("Цифры числа в массиве:");
foreach (var digit in digits)
{
    Console.Write(digit);
}
