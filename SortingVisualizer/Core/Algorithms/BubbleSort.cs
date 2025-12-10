

namespace SortingVisualizer
{
    public class BubbleSort : ISortAlgorithm
    {
        public string Name => "Bubble Sort";

        public async Task Sort(
            int[] array,
            Action<SortStep> onStep,
            int delay,
            CancellationToken token)
        {
            MainForm.LastComparisons = 0;
            MainForm.LastSwaps = 0;
            MainForm.LastWrites = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    token.ThrowIfCancellationRequested();

                    MainForm.LastComparisons++;

                    onStep(new SortStep(array.ToArray(), compareA: j, compareB: j + 1));
                    await Task.Delay(delay, token);

                    if (array[j] > array[j + 1])
                    {
                        MainForm.LastSwaps++;

                        (array[j], array[j + 1]) = (array[j + 1], array[j]);

                        onStep(new SortStep(array.ToArray(), swapA: j, swapB: j + 1));
                        await Task.Delay(delay, token);
                    }
                }
            }

            onStep(new SortStep(array.ToArray()));
        }
    }
}