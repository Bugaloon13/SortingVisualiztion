
using SortingVisualizer.Visualization;

namespace SortingVisualizer
{
    public interface ISortAlgorithm
    {
        string Name { get; }

        Task Sort(
            int[] array,
            Action<SortStep> onStep,
            int delay,
            CancellationToken token,
            Action onCompare,
            Action onSwap,
            Action onWrite
        );
    }
}