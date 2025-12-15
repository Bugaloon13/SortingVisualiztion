namespace SortingVisualizer
{
    public static class AlgorithmInfoProvider
    {
        public static AlgorithmInfo GetInfo(string name)
        {
            return name switch
            {
                "Bubble Sort" => Bubble(),
                "Selection Sort" => Selection(),
                "Insertion Sort" => Insertion(),
                "Quick Sort" => Quick(),
                "Merge Sort" => Merge(),
                "Heap Sort" => Heap(),
                _ => null
            };
        }

        private static AlgorithmInfo Bubble() => new AlgorithmInfo
        {
            Name = "Bubble Sort",
            Description =
@"Сортировка пузырьком — простой алгоритм сортировки, основанный на
многократном сравнении соседних элементов массива и их обмене,
если они находятся в неправильном порядке.

После каждого прохода наибольший элемент «всплывает» в конец массива.
Алгоритм прост для понимания и реализации, но крайне неэффективен
для больших наборов данных и используется в основном в учебных целях.

Сложность (Big O):
Лучший случай: O(n)
Средний случай: O(n²)
Худший случай: O(n²)
Память: O(1)",

            Code =
@"for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = 0; j < arr.Length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }
    }
}"
        };

        private static AlgorithmInfo Selection() => new AlgorithmInfo
        {
            Name = "Selection Sort",
            Description =
@"Сортировка выбором основана на поиске минимального элемента
в неотсортированной части массива и его обмене с первым элементом
этой части.

Алгоритм всегда выполняет одинаковое количество сравнений,
независимо от исходного состояния массива, но делает минимальное
количество обменов.

Сложность (Big O):
Лучший случай: O(n²)
Средний случай: O(n²)
Худший случай: O(n²)
Память: O(1)",

            Code =
@"for (int i = 0; i < arr.Length - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < arr.Length; j++)
        if (arr[j] < arr[min])
            min = j;

    (arr[i], arr[min]) = (arr[min], arr[i]);
}"
        };

        private static AlgorithmInfo Insertion() => new AlgorithmInfo
        {
            Name = "Insertion Sort",
            Description =
@"Сортировка вставками работает по принципу сортировки карт в руке.
Каждый новый элемент вставляется в уже отсортированную часть массива
на правильную позицию.

Алгоритм очень эффективен для почти отсортированных данных,
но плохо масштабируется на больших массивах.

Сложность (Big O):
Лучший случай: O(n)
Средний случай: O(n²)
Худший случай: O(n²)
Память: O(1)",

            Code =
@"for (int i = 1; i < arr.Length; i++)
{
    int key = arr[i];
    int j = i - 1;

    while (j >= 0 && arr[j] > key)
    {
        arr[j + 1] = arr[j];
        j--;
    }

    arr[j + 1] = key;
}"
        };

        private static AlgorithmInfo Quick() => new AlgorithmInfo
        {
            Name = "Quick Sort",
            Description =
@"Быстрая сортировка использует стратегию «разделяй и властвуй».
Выбирается опорный элемент, массив делится на элементы меньше и больше
опорного, после чего каждая часть сортируется рекурсивно.

Один из самых быстрых алгоритмов сортировки на практике,
но в худшем случае может работать медленно.

Сложность (Big O):
Лучший случай: O(n log n)
Средний случай: O(n log n)
Худший случай: O(n²)
Память: O(log n)",

            Code =
@"void QuickSort(int[] arr, int left, int right)
{
    int i = left, j = right;
    int pivot = arr[(left + right) / 2];

    while (i <= j)
    {
        while (arr[i] < pivot) i++;
        while (arr[j] > pivot) j--;

        if (i <= j)
        {
            (arr[i], arr[j]) = (arr[j], arr[i]);
            i++; j--;
        }
    }

    if (left < j) QuickSort(arr, left, j);
    if (i < right) QuickSort(arr, i, right);
}"
        };

        private static AlgorithmInfo Merge() => new AlgorithmInfo
        {
            Name = "Merge Sort",
            Description =
@"Сортировка слиянием использует принцип «разделяй и властвуй».
Массив рекурсивно разбивается на две части, которые сортируются
и затем сливаются в один упорядоченный массив.

Алгоритм стабилен и гарантирует одинаковую производительность
в любых случаях, но требует дополнительной памяти.

Сложность (Big O):
Лучший случай: O(n log n)
Средний случай: O(n log n)
Худший случай: O(n log n)
Память: O(n)",

            Code =
@"int[] MergeSort(int[] arr)
{
    if (arr.Length <= 1)
        return arr;

    int mid = arr.Length / 2;
    int[] left = MergeSort(arr[..mid]);
    int[] right = MergeSort(arr[mid..]);

    return Merge(left, right);
}"
        };

        private static AlgorithmInfo Heap() => new AlgorithmInfo
        {
            Name = "Heap Sort",
            Description =
@"Пирамидальная сортировка использует структуру данных «двоичная куча».
Сначала строится max-heap, после чего наибольший элемент
последовательно извлекается и помещается в конец массива.

Алгоритм не является стабильным, но гарантирует хорошую
производительность и не требует дополнительной памяти.

Сложность (Big O):
Лучший случай: O(n log n)
Средний случай: O(n log n)
Худший случай: O(n log n)
Память: O(1)",

            Code =
@"void HeapSort(int[] arr)
{
    int n = arr.Length;

    for (int i = n / 2 - 1; i >= 0; i--)
        Heapify(arr, n, i);

    for (int i = n - 1; i > 0; i--)
    {
        (arr[0], arr[i]) = (arr[i], arr[0]);
        Heapify(arr, i, 0);
    }
}"
        };
    }

    public class AlgorithmInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
