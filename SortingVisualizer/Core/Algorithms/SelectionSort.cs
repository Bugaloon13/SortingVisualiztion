
using SortingVisualizer.Visualization;

namespace SortingVisualizer
{
    public class SelectionSort : ISortAlgorithm
    {
        public string Name => "Selection Sort";

        public async Task Sort(
            int[] array,
            System.Action<SortStep> onStep,
            int delay,
            CancellationToken token,
            System.Action onCompare,
            System.Action onSwap,
            System.Action onWrite)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    token.ThrowIfCancellationRequested();

                    onCompare();
                    onStep(new SortStep(array[..], compareA: min, compareB: j));
                    await Task.Delay(delay, token);

                    if (array[j] < array[min])
                        min = j;
                }

                if (min != i)
                {
                    onSwap();
                    (array[i], array[min]) = (array[min], array[i]);

                    onStep(new SortStep(array[..], swapA: i, swapB: min));
                    await Task.Delay(delay, token);
                }
            }
        }
    }
}