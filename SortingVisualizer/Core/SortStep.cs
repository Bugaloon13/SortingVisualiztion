namespace SortingVisualizer.Visualization
{
    public class SortStep
    {
        public int[] Array { get; }

        public int CompareA { get; }
        public int CompareB { get; }
        public int SwapA { get; }
        public int SwapB { get; }
        public int WriteIndex { get; }

        public SortStep(
            int[] array,
            int compareA = -1,
            int compareB = -1,
            int swapA = -1,
            int swapB = -1,
            int writeIndex = -1)
        {
            Array = array;
            CompareA = compareA;
            CompareB = compareB;
            SwapA = swapA;
            SwapB = swapB;
            WriteIndex = writeIndex;
        }
    }
}