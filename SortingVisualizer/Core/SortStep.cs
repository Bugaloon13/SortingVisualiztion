namespace SortingVisualizer
{
    public class SortStep
    {
        public int[] Array { get; }
        public int? CompareA { get; }
        public int? CompareB { get; }
        public int? SwapA { get; }
        public int? SwapB { get; }

        public SortStep(int[] array, int? compareA = null, int? compareB = null,
            int? swapA = null, int? swapB = null)
        {
            Array = array;
            CompareA = compareA;
            CompareB = compareB;
            SwapA = swapA;
            SwapB = swapB;
        }
    }
}