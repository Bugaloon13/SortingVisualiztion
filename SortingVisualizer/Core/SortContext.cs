

namespace SortingVisualizer
{
    public class SortContext
    {
        public ISortAlgorithm Algorithm { get; set; }

        public Task RunAsync(
            int[] array,
            Action<SortStep> onStep,
            int delay,
            CancellationToken token)
        {
            if (Algorithm == null)
                throw new InvalidOperationException("Algorithm is not set.");

            return Algorithm.Sort(array, onStep, delay, token);
        }
    }
}