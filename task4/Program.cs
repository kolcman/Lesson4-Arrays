int[] array = {5,11,67,758,18,8,154,22,12,43};
int max = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max){
//         max = array[i];
//     }
// }

foreach (int i in array)
{
    if (i > max){
        max = i;
    }
}

System.Console.WriteLine($"Максимальная гиря: {max}");