using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class QuickSort : ISortAlgorithm
    {
        public string Name => "Quick Sort";

        public async Task Sort(
            int[] arr,
            Action<SortStep> onStep,
            int delay,
            CancellationToken token)
        {
            MainForm.LastComparisons = 0;
            MainForm.LastSwaps = 0;
            MainForm.LastWrites = 0;

            await Quick(arr, 0, arr.Length - 1, onStep, delay, token);

            onStep(new SortStep(arr.ToArray()));
        }

        private async Task Quick(
            int[] arr, int left, int right,
            Action<SortStep> onStep,
            int delay, CancellationToken token)
        {
            if (left >= right)
                return;

            int pivot = arr[(left + right) / 2];

            int i = left;
            int j = right;

            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    token.ThrowIfCancellationRequested();
                    MainForm.LastComparisons++;

                    onStep(new SortStep(arr.ToArray(), compareA: i));
                    await Task.Delay(delay, token);

                    i++;
                }

                while (arr[j] > pivot)
                {
                    token.ThrowIfCancellationRequested();
                    MainForm.LastComparisons++;

                    onStep(new SortStep(arr.ToArray(), compareA: j));
                    await Task.Delay(delay, token);

                    j--;
                }

                if (i <= j)
                {
                    MainForm.LastSwaps++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);

                    onStep(new SortStep(arr.ToArray(), swapA: i, swapB: j));
                    await Task.Delay(delay, token);

                    i++;
                    j--;
                }
            }

            await Quick(arr, left, j, onStep, delay, token);
            await Quick(arr, i, right, onStep, delay, token);
        }
    }
}
