

namespace SortingVisualizer.Visualization
{
    public partial class SortView : UserControl
    {
        private readonly ISortAlgorithm algorithm;
        private int[] array;
        private int[] current;

        private int compareA = -1;
        private int compareB = -1;
        private int swapA = -1;
        private int swapB = -1;
        private int writeIndex = -1;

        private int comparisons;
        private int swaps;
        private int writes;

        private CancellationTokenSource cts;

        public SortView(ISortAlgorithm algorithm, int[] baseArray)
        {
            InitializeComponent();

            this.algorithm = algorithm;
            array = baseArray.ToArray();
            current = baseArray.ToArray();

            labelTitle.Text = algorithm.Name;

            panelDraw.Paint += PanelDraw_Paint;

            typeof(Panel).InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                panelDraw,
                new object[] { true }
            );

            Dock = DockStyle.Fill;
            MinimumSize = new Size(200, 150);
        }

        public void SetInitialArray(int[] arr)
        {
            array = arr.ToArray();
            current = arr.ToArray();
            panelDraw.Invalidate();
        }

        public async Task StartAsync(int delay)
        {
            comparisons = swaps = writes = 0;
            cts = new CancellationTokenSource();

            try
            {
                await algorithm.Sort(
                    array,
                    step =>
                    {
                        current = step.Array;

                        compareA = step.CompareA;
                        compareB = step.CompareB;
                        swapA = step.SwapA;
                        swapB = step.SwapB;
                        writeIndex = step.WriteIndex;

                        if (panelDraw.IsHandleCreated)
                            panelDraw.Invoke(new Action(panelDraw.Invalidate));
                    },
                    delay,
                    cts.Token,
                    () => comparisons++,
                    () => swaps++,
                    () => writes++
                );
            }
            catch (OperationCanceledException)
            {
            }
        }

        public void Stop()
        {
            cts?.Cancel();
        }

        private void PanelDraw_Paint(object sender, PaintEventArgs e)
        {
            if (current == null || current.Length == 0)
                return;

            Graphics g = e.Graphics;

            int w = panelDraw.ClientSize.Width;
            int h = panelDraw.ClientSize.Height;

            int maxValue = current.Max();
            float barWidth = (float)w / current.Length;

            for (int i = 0; i < current.Length; i++)
            {
                float height = (float)current[i] / maxValue * (h - 20);
                float x = i * barWidth;
                float y = h - height;

                Brush brush = Brushes.CornflowerBlue;

                if (i == compareA || i == compareB)
                    brush = Brushes.Gold;
                else if (i == swapA || i == swapB)
                    brush = Brushes.Red;
                else if (i == writeIndex)
                    brush = Brushes.LimeGreen;

                g.FillRectangle(
                    brush,
                    x,
                    y,
                    Math.Max(1, barWidth - 1),
                    height
                );
            }

            string stats =
                $"Comparisons: {comparisons}   Swaps: {swaps}   Writes: {writes}";

            g.DrawString(
                stats,
                Font,
                Brushes.White,
                new PointF(5, 5)
            );
        }
    }
}
