using System.Collections.Generic;
using System.Windows.Forms;

namespace SortingVisualizer
{
    public partial class ComparisonForm : Form
    {
        public ComparisonForm()
        {
            InitializeComponent();

            grid.Columns.Clear();

            grid.Columns.Add("Algorithm", "Algorithm");
            grid.Columns.Add("TimeMs", "Time (ms)");
            grid.Columns.Add("Comparisons", "Comparisons");
            grid.Columns.Add("Swaps", "Swaps");
            grid.Columns.Add("Writes", "Writes");

            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ShowResults(List<AlgorithmResult> results)
        {
            grid.Rows.Clear();

            foreach (var r in results)
            {
                grid.Rows.Add(r.Algorithm, r.TimeMs, r.Comparisons, r.Swaps, r.Writes);
            }
        }
    }

    public class AlgorithmResult
    {
        public string Algorithm { get; set; }
        public long TimeMs { get; set; }
        public int Comparisons { get; set; }
        public int Swaps { get; set; }
        public int Writes { get; set; }
    }
}