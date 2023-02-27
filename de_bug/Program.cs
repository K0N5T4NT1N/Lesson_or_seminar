
int[] GetShuffleArray()
{
    int[] array = new int[90];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 10;
    }

    Random rand = new Random();

    for (int i = array.Length - 1; i >= 1; i--)
    {
        int k = rand.Next(i + 1);

        int temp = array[k];
        array[k] = array[i];
        array[i] = temp;
    }
    return array;
}
Console.ReadKey();
int[] fillarray = GetShuffleArray();
Console.Write($"[{String.Join(", ", fillarray)}]");
Console.ReadKey();