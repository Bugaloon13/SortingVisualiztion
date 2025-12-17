
using SortingVisualizer.Visualization;

namespace SortingVisualizer
{
    public class BubbleSort : ISortAlgorithm
    {
        public string Name => "Bubble Sort";

        public async Task Sort(
            int[] array,
            Action<SortStep> onStep,
            int delay,
            CancellationToken token,
            Action onCompare,
            Action onSwap,
            Action onWrite)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    token.ThrowIfCancellationRequested();

                    onCompare();
                    onStep(new SortStep(array[..], compareA: j, compareB: j + 1));
                    await Task.Delay(delay, token);

                    if (array[j] > array[j + 1])
                    {
                        onSwap();
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);

                        onStep(new SortStep(array[..], swapA: j, swapB: j + 1));
                        await Task.Delay(delay, token);
                    }
                }
            }
        }
    }
}