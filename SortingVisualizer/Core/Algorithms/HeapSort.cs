using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class HeapSort : ISortAlgorithm
    {
        public string Name => "Heap Sort";

        public async Task Sort(
            int[] arr,
            Action<SortStep> onStep,
            int delay,
            CancellationToken token)
        {
            MainForm.LastComparisons = 0;
            MainForm.LastSwaps = 0;
            MainForm.LastWrites = 0;

            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                await Heapify(arr, n, i, onStep, delay, token);

            for (int i = n - 1; i > 0; i--)
            {
                MainForm.LastSwaps++;
                (arr[0], arr[i]) = (arr[i], arr[0]);

                onStep(new SortStep(arr.ToArray(), swapA: 0, swapB: i));
                await Task.Delay(delay, token);

                await Heapify(arr, i, 0, onStep, delay, token);
            }

            onStep(new SortStep(arr.ToArray()));
        }

        private async Task Heapify(
            int[] arr, int size, int root,
            Action<SortStep> onStep,
            int delay, CancellationToken token)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < size)
            {
                MainForm.LastComparisons++;
                onStep(new SortStep(arr.ToArray(), compareA: root, compareB: left));
                await Task.Delay(delay, token);

                if (arr[left] > arr[largest])
                    largest = left;
            }

            if (right < size)
            {
                MainForm.LastComparisons++;
                onStep(new SortStep(arr.ToArray(), compareA: root, compareB: right));
                await Task.Delay(delay, token);

                if (arr[right] > arr[largest])
                    largest = right;
            }

            if (largest != root)
            {
                MainForm.LastSwaps++;

                (arr[root], arr[largest]) = (arr[largest], arr[root]);

                onStep(new SortStep(arr.ToArray(), swapA: root, swapB: largest));
                await Task.Delay(delay, token);

                await Heapify(arr, size, largest, onStep, delay, token);
            }
        }
    }
}
