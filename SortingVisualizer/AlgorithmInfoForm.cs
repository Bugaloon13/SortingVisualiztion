
namespace SortingVisualizer
{
    public partial class AlgorithmInfoForm : Form
    {
        public AlgorithmInfoForm(AlgorithmInfo info)
        {
            InitializeComponent();

            Text = info.Name;
            txtDescription.Text = info.Description;
            txtCode.Text = info.Code;
        }
    }
}