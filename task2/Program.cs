// Task2

System.Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < array.Length ; i++)
{
    array[i] = i + 1;
}
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}



