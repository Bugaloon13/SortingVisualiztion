namespace SortingVisualizer.Visualization
{
    partial class SortView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Label labelTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelDraw = new System.Windows.Forms.Panel();
            labelTitle = new System.Windows.Forms.Label();

            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Height = 20;
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelTitle.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDraw.BackColor = System.Drawing.Color.Black;

            BackColor = System.Drawing.Color.Black;
            Controls.Add(panelDraw);
            Controls.Add(labelTitle);

            Name = "SortView";
            Size = new System.Drawing.Size(300, 200);
        }
    }
}