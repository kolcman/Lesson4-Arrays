int[] array = {5,1117,67,75,18,8,154,22,12,43};
int max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max){
        max = array[i];
    }
}

System.Console.WriteLine($"Максимальная гиря: {max}");