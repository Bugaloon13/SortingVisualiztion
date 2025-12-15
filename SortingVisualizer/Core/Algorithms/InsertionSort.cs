
using SortingVisualizer.Visualization;

namespace SortingVisualizer
{
    public class InsertionSort : ISortAlgorithm
    {
        public string Name => "Insertion Sort";

        public async Task Sort(
            int[] array,
            System.Action<SortStep> onStep,
            int delay,
            CancellationToken token,
            System.Action onCompare,
            System.Action onSwap,
            System.Action onWrite)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0)
                {
                    token.ThrowIfCancellationRequested();

                    onCompare();
                    onStep(new SortStep(array[..], compareA: j, compareB: i));
                    await Task.Delay(delay, token);

                    if (array[j] <= key)
                        break;

                    onWrite();
                    array[j + 1] = array[j];
                    onStep(new SortStep(array[..], writeIndex: j + 1));
                    await Task.Delay(delay, token);

                    j--;
                }

                onWrite();
                array[j + 1] = key;
                onStep(new SortStep(array[..], writeIndex: j + 1));
                await Task.Delay(delay, token);
            }
        }
    }
}