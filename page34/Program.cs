int num = 0;
int[] array = new int[11];
Random count = new Random();
for (int i = 0; i <= 10; i++)
{
    array[i] = count.Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        num += 1;
    }
}

foreach (int k in array) Console.Write(k + " ");
Console.Write($"---> {num}");