

namespace SortingVisualizer
{
    public class MergeSort : ISortAlgorithm
    {
        public string Name => "Merge Sort";

        public async Task Sort(
            int[] arr,
            Action<SortStep> onStep,
            int delay,
            CancellationToken token)
        {
            MainForm.LastComparisons = 0;
            MainForm.LastSwaps = 0;     // mergesort = 0 swaps всегда
            MainForm.LastWrites = 0;

            await MergeRec(arr, 0, arr.Length - 1, onStep, delay, token);

            onStep(new SortStep(arr.ToArray()));
        }

        private async Task MergeRec(int[] arr, int left, int right,
            Action<SortStep> onStep, int delay, CancellationToken token)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            await MergeRec(arr, left, mid, onStep, delay, token);
            await MergeRec(arr, mid + 1, right, onStep, delay, token);

            await Merge(arr, left, mid, right, onStep, delay, token);
        }

        private async Task Merge(
            int[] arr, int left, int mid, int right,
            Action<SortStep> onStep, int delay, CancellationToken token)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                token.ThrowIfCancellationRequested();
                MainForm.LastComparisons++;

                onStep(new SortStep(arr.ToArray(), compareA: i, compareB: j));
                await Task.Delay(delay, token);

                if (arr[i] <= arr[j]) temp[k++] = arr[i++];
                else temp[k++] = arr[j++];
            }

            while (i <= mid) temp[k++] = arr[i++];
            while (j <= right) temp[k++] = arr[j++];

            // перезапись
            for (int t = 0; t < temp.Length; t++)
            {
                arr[left + t] = temp[t];
                MainForm.LastWrites++;

                onStep(new SortStep(arr.ToArray(), swapA: left + t));
                await Task.Delay(delay, token);
            }
        }
    }
}
