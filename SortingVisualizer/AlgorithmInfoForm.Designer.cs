namespace SortingVisualizer
{
    partial class AlgorithmInfoForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.SplitContainer splitContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDescription = new System.Windows.Forms.TextBox();
            txtCode = new System.Windows.Forms.TextBox();
            splitContainer = new System.Windows.Forms.SplitContainer();

            // splitContainer
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            splitContainer.IsSplitterFixed = false;

            // txtDescription
            txtDescription.Multiline = true;
            txtDescription.ReadOnly = true;
            txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtCode
            txtCode.Multiline = true;
            txtCode.ReadOnly = true;
            txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtCode.Font = new System.Drawing.Font("Consolas", 9F);

            // assemble
            splitContainer.Panel1.Controls.Add(txtDescription);
            splitContainer.Panel2.Controls.Add(txtCode);

            Controls.Add(splitContainer);

            ClientSize = new System.Drawing.Size(800, 550);

            splitContainer.SplitterDistance = ClientSize.Height / 2;

            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Algorithm Info";
        }
    }
}
