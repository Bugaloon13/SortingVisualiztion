using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SortingVisualizer
{
    public partial class MainForm : Form   
    {
        private int[]? array;
        private ArrayDrawer drawer;
        private SortContext context;
        private CancellationTokenSource? cts;
        public static int LastComparisons = 0;
        public static int LastSwaps = 0;      
        public static int LastWrites = 0;     


        public MainForm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panelDisplay, new object[] { true });


            drawer = new ArrayDrawer(panelDisplay);
            context = new SortContext();

            // Добавляем алгоритмы в comboBox
            comboAlgorithms.Items.Add(new BubbleSort());
            comboAlgorithms.Items.Add(new SelectionSort());
            comboAlgorithms.Items.Add(new InsertionSort());
            comboAlgorithms.Items.Add(new QuickSort());
            comboAlgorithms.Items.Add(new MergeSort());
            comboAlgorithms.Items.Add(new HeapSort());

            comboAlgorithms.DisplayMember = "Name";
            comboAlgorithms.SelectedIndex = 0;

            // Привязываем кнопки
            btnGenerate.Click += btnGenerate_Click;
            btnStart.Click += btnStart_Click;
            btnStop.Click += btnStop_Click;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            array = ArrayGenerator.Generate((int)numSize.Value, panelDisplay.Height);
            drawer.Draw(new SortStep(array));
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            if (comboAlgorithms.SelectedItem is not ISortAlgorithm algorithm)
            {
                MessageBox.Show("Выберите алгоритм.");
                return;
            }

            // СБРОС СЧЁТЧИКОВ
            MainForm.LastComparisons = 0;
            MainForm.LastSwaps = 0;
            MainForm.LastWrites = 0;

            lblComparisons.Text = "Comparisons: 0";
            lblSwaps.Text       = "Swaps: 0";
            lblWrites.Text      = "Writes: 0";

            // БЛОКИРУЕМ КНОПКИ
            btnStart.Enabled = false;
            btnGenerate.Enabled = false;
            btnCompare.Enabled = false;
            comboAlgorithms.Enabled = false;
            btnStop.Enabled = true;

            cts?.Cancel();
            cts = new CancellationTokenSource();
            context.Algorithm = algorithm;

            try
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();

                await context.RunAsync(
                    array,
                    step =>
                    {
                        drawer.Draw(step);
                        lblComparisons.Text = $"Comparisons: {MainForm.LastComparisons}";
                        lblSwaps.Text       = $"Swaps: {MainForm.LastSwaps}";
                        lblWrites.Text      = $"Writes: {MainForm.LastWrites}";
                    },
                    trackSpeed.Value,
                    cts.Token
                );

                sw.Stop();
            }
            catch (OperationCanceledException)
            {
                // нормально
            }
            finally
            {
                // РАЗБЛОКИРУЕМ КНОПКИ
                btnStart.Enabled = true;
                btnGenerate.Enabled = true;
                btnCompare.Enabled = true;
                comboAlgorithms.Enabled = true;
                btnStop.Enabled = false;
            }
        }




        private void btnStop_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }
        
        
        
        private async void btnCompare_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            btnCompare.Enabled = false;
            btnStart.Enabled = false;
            btnGenerate.Enabled = false;
            comboAlgorithms.Enabled = false;
            btnStop.Enabled = false;

            int[] original = array.ToArray();

            var algorithms = new ISortAlgorithm[]
            {
                new BubbleSort(),
                new SelectionSort(),
                new InsertionSort(),
                new QuickSort(),
                new MergeSort(),
                new HeapSort()
            };

            var results = new List<AlgorithmResult>();

            foreach (var alg in algorithms)
            {
                int[] arrCopy = original.ToArray();

                MainForm.LastComparisons = 0;
                MainForm.LastSwaps = 0;

                var sw = System.Diagnostics.Stopwatch.StartNew();

                await alg.Sort(
                    arrCopy,
                    step => { }, // без визуализации
                    0,
                    CancellationToken.None
                );

                sw.Stop();

                results.Add(new AlgorithmResult
                {
                    Algorithm = alg.Name,
                    TimeMs = sw.ElapsedMilliseconds,
                    Comparisons = MainForm.LastComparisons,
                    Swaps = MainForm.LastSwaps,
                    Writes = MainForm.LastWrites
                });
            }

            // отображаем результаты в таблице
            var form = new ComparisonForm();
            form.ShowResults(results);
            form.Show();

            btnCompare.Enabled = true;
            btnStart.Enabled = true;
            btnGenerate.Enabled = true;
            comboAlgorithms.Enabled = true;
        }
        
    }
}
