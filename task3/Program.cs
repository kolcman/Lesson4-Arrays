// Task2:2

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine("Введите число");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        System.Console.Write(array[i]);
    }
}