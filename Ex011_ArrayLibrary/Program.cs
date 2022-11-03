void FillArray(int[] collection)
{
    for (int i = collection.Length - 1; i >= 0; i--)
    {
        collection[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.WriteLine(i + " " + collection[i]);
    }

}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

