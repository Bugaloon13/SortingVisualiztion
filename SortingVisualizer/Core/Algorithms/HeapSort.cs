
using SortingVisualizer.Visualization;

namespace SortingVisualizer
{
    public class HeapSort : ISortAlgorithm
    {
        public string Name => "Heap Sort";

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

            for (int i = n / 2 - 1; i >= 0; i--)
                await Heapify(n, i);

            for (int i = n - 1; i > 0; i--)
            {
                onSwap();
                (array[0], array[i]) = (array[i], array[0]);
                onStep(new SortStep(array[..], swapA: 0, swapB: i));
                await Task.Delay(delay, token);

                await Heapify(i, 0);
            }

            async Task Heapify(int size, int i)
            {
                int largest = i;
                int l = 2 * i + 1;
                int r = 2 * i + 2;

                if (l < size)
                {
                    onCompare();
                    if (array[l] > array[largest])
                        largest = l;
                }

                if (r < size)
                {
                    onCompare();
                    if (array[r] > array[largest])
                        largest = r;
                }

                if (largest != i)
                {
                    onSwap();
                    (array[i], array[largest]) = (array[largest], array[i]);
                    onStep(new SortStep(array[..], swapA: i, swapB: largest));
                    await Task.Delay(delay, token);

                    await Heapify(size, largest);
                }
            }
        }
    }
}