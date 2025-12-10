using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SortingVisualizer
{
    public class SelectionSort : ISortAlgorithm
    {
        public string Name => "Selection Sort";

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
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    token.ThrowIfCancellationRequested();

                    MainForm.LastComparisons++;

                    onStep(new SortStep(array.ToArray(), compareA: minIndex, compareB: j));
                    await Task.Delay(delay, token);

                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    MainForm.LastSwaps++;

                    (array[i], array[minIndex]) = (array[minIndex], array[i]);

                    onStep(new SortStep(array.ToArray(), swapA: i, swapB: minIndex));
                    await Task.Delay(delay, token);
                }
            }

            onStep(new SortStep(array.ToArray()));
        }
    }
}