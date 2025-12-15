
using SortingVisualizer.Visualization;

namespace SortingVisualizer
{
    public partial class MainForm : Form
    {
        private int[] baseArray;
        
        private void ShowInfo(string algorithmName)
        {
            var info = AlgorithmInfoProvider.GetInfo(algorithmName);

            var form = new AlgorithmInfoForm(
                info
            );

            form.ShowDialog(this);
        }

        public MainForm()
        {
            InitializeComponent();
            btnInfoBubble.Click += (_, _) => ShowInfo("Bubble Sort");
            btnInfoSelection.Click += (_, _) => ShowInfo("Selection Sort");
            btnInfoInsertion.Click += (_, _) => ShowInfo("Insertion Sort");
            btnInfoQuick.Click += (_, _) => ShowInfo("Quick Sort");
            btnInfoMerge.Click += (_, _) => ShowInfo("Merge Sort");
            btnInfoHeap.Click += (_, _) => ShowInfo("Heap Sort");

            btnGenerate.Click += btnGenerate_Click;
            btnStart.Click += btnStart_Click;
            btnStop.Click += btnStop_Click;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            baseArray = ArrayGenerator.Generate(
                (int)numSize.Value,
                150
            );

            tablePanel.Controls.Clear();
            tablePanel.RowStyles.Clear();
            tablePanel.RowCount = 0;

            var algorithms = new List<ISortAlgorithm>();

            if (chkBubble.Checked) algorithms.Add(new BubbleSort());
            if (chkSelection.Checked) algorithms.Add(new SelectionSort());
            if (chkInsertion.Checked) algorithms.Add(new InsertionSort());
            if (chkQuick.Checked) algorithms.Add(new QuickSort());
            if (chkMerge.Checked) algorithms.Add(new MergeSort());
            if (chkHeap.Checked) algorithms.Add(new HeapSort());

            int colCount = tablePanel.ColumnCount;
            int index = 0;

            foreach (var alg in algorithms)
            {
                int row = index / colCount;
                int col = index % colCount;

                if (row >= tablePanel.RowCount)
                {
                    tablePanel.RowCount++;
                    tablePanel.RowStyles.Add(
                        new RowStyle(SizeType.Percent, 100f)
                    );
                }

                var view = new SortView(alg, baseArray);
                view.SetInitialArray(baseArray);   
                tablePanel.Controls.Add(view, col, row);

                index++;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (tablePanel.Controls.Count == 0)
            {
                MessageBox.Show("Сначала нажмите Generate");
                return;
            }

            btnStart.Enabled = false;
            btnGenerate.Enabled = false;

            var tasks = new List<Task>();

            foreach (Control c in tablePanel.Controls)
            {
                if (c is SortView view)
                {
                    tasks.Add(view.StartAsync(trackSpeed.Value));
                }
            }

            try
            {
                await Task.WhenAll(tasks);
            }
            catch
            {
            }

            btnStart.Enabled = true;
            btnGenerate.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            foreach (Control c in tablePanel.Controls)
            {
                if (c is SortView view)
                    view.Stop();
            }
        }
        
    }
}
