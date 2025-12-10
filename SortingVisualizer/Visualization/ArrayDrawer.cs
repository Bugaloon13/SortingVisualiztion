using System.Drawing;
using System.Windows.Forms;

namespace SortingVisualizer
{
    public class ArrayDrawer
    {
        private readonly Panel _panel;

        public ArrayDrawer(Panel panel)
        {
            _panel = panel;
        }

        public void Draw(SortStep step)
        {
            int[] array = step.Array;

            var bmp = new Bitmap(_panel.Width, _panel.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);

                int barWidth = Math.Max(1, _panel.Width / array.Length);

                for (int i = 0; i < array.Length; i++)
                {
                    Brush color = Brushes.CornflowerBlue;

                    if (i == step.CompareA || i == step.CompareB)
                        color = Brushes.LimeGreen;

                    if (i == step.SwapA || i == step.SwapB)
                        color = Brushes.Red;

                    int h = array[i];
                    g.FillRectangle(color,
                        i * barWidth,
                        _panel.Height - h,
                        barWidth - 1,
                        h);
                }
            }

            _panel.BackgroundImage?.Dispose();
            _panel.BackgroundImage = bmp;
        }
    }
}