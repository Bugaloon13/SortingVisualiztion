
using SortingVisualizer.Visualization;

namespace SortingVisualizer
{
    public class MergeSort : ISortAlgorithm
    {
        public string Name => "Merge Sort";

        public async Task Sort(
            int[] array,
            System.Action<SortStep> onStep,
            int delay,
            CancellationToken token,
            System.Action onCompare,
            System.Action onSwap,
            System.Action onWrite)
        {
            await Merge(array, 0, array.Length - 1);

            async Task Merge(int[] arr, int l, int r)
            {
                if (l >= r) return;

                int m = (l + r) / 2;
                await Merge(arr, l, m);
                await Merge(arr, m + 1, r);

                int[] temp = new int[r - l + 1];
                int i = l, j = m + 1, k = 0;

                while (i <= m && j <= r)
                {
                    token.ThrowIfCancellationRequested();

                    onCompare();

                    if (arr[i] <= arr[j])
                        temp[k++] = arr[i++];
                    else
                        temp[k++] = arr[j++];
                }

                while (i <= m) temp[k++] = arr[i++];
                while (j <= r) temp[k++] = arr[j++];

                for (int x = 0; x < temp.Length; x++)
                {
                    onWrite();
                    arr[l + x] = temp[x];
                    onStep(new SortStep(arr[..], writeIndex: l + x));
                    await Task.Delay(delay, token);
                }
            }
        }
    }
}