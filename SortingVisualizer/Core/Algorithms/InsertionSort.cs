

namespace SortingVisualizer
{
    public class InsertionSort : ISortAlgorithm
    {
        public string Name => "Insertion Sort";

        public async Task Sort(
            int[] array,
            Action<SortStep> onStep,
            int delay,
            CancellationToken token)
        {
            MainForm.LastComparisons = 0;
            MainForm.LastSwaps = 0;
            MainForm.LastWrites = 0;

            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0)
                {
                    token.ThrowIfCancellationRequested();

                    MainForm.LastComparisons++;

                    onStep(new SortStep(array.ToArray(), compareA: j, compareB: i));
                    await Task.Delay(delay, token);

                    if (array[j] > key)
                    {
                        // перезапись
                        array[j + 1] = array[j];
                        MainForm.LastWrites++;

                        onStep(new SortStep(array.ToArray(), swapA: j + 1, swapB: j));
                        await Task.Delay(delay, token);
                    }
                    else break;

                    j--;
                }

                array[j + 1] = key;
                MainForm.LastWrites++;

                onStep(new SortStep(array.ToArray(), swapA: j + 1));
                await Task.Delay(delay, token);
            }

            onStep(new SortStep(array.ToArray()));
        }
    }
}