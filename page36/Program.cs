int num = 0;
int[] array = new int[6];
Random count = new Random();
for (int i = 0; i <= 5; i++)
{
    array[i] = count.Next(-20, 21);
    if (i % 2 == 0)
    {
        num += array[i];
    }
}

foreach (int k in array) Console.Write(k + " ");
Console.Write($"---> {num}");