namespace SortingVisualizer;

public static partial class ArrayGenerator
{
    private static Random rnd = new Random();

    public static int[] Generate(int size, int maxHeight)
    {
        var arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = rnd.Next(5, maxHeight);

        return arr;
    }
}