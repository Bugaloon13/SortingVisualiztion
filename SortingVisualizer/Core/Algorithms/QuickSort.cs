
using SortingVisualizer.Visualization;

namespace SortingVisualizer
{
    public class QuickSort : ISortAlgorithm
    {
        public string Name => "Quick Sort";

        public async Task Sort(
            int[] array,
            System.Action<SortStep> onStep,
            int delay,
            CancellationToken token,
            System.Action onCompare,
            System.Action onSwap,
            System.Action onWrite)
        {
            await Quick(array, 0, array.Length - 1);

            async Task Quick(int[] arr, int low, int high)
            {
                if (low >= high) return;

                int p = await Partition(arr, low, high);
                await Quick(arr, low, p - 1);
                await Quick(arr, p + 1, high);
            }

            async Task<int> Partition(int[] arr, int low, int high)
            {
                int pivot = arr[high];
                int i = low;

                for (int j = low; j < high; j++)
                {
                    token.ThrowIfCancellationRequested();

                    onCompare();
                    onStep(new SortStep(arr[..], compareA: j, compareB: high));
                    await Task.Delay(delay, token);

                    if (arr[j] < pivot)
                    {
                        onSwap();
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                        onStep(new SortStep(arr[..], swapA: i, swapB: j));
                        await Task.Delay(delay, token);
                        i++;
                    }
                }

                onSwap();
                (arr[i], arr[high]) = (arr[high], arr[i]);
                onStep(new SortStep(arr[..], swapA: i, swapB: high));
                await Task.Delay(delay, token);

                return i;
            }
        }
    }
}