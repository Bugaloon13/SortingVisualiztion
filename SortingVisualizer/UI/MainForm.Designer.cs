namespace SortingVisualizer;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnGenerate = new System.Windows.Forms.Button();
        btnStart = new System.Windows.Forms.Button();
        btnStop = new System.Windows.Forms.Button();
        numSize = new System.Windows.Forms.NumericUpDown();
        trackSpeed = new System.Windows.Forms.TrackBar();
        lbSize = new System.Windows.Forms.Label();
        lbSpeed = new System.Windows.Forms.Label();
        chkBubble = new System.Windows.Forms.CheckBox();
        chkSelection = new System.Windows.Forms.CheckBox();
        chkInsertion = new System.Windows.Forms.CheckBox();
        chkHeap = new System.Windows.Forms.CheckBox();
        chkMerge = new System.Windows.Forms.CheckBox();
        chkQuick = new System.Windows.Forms.CheckBox();
        tablePanel = new System.Windows.Forms.TableLayoutPanel();
        splitContainer = new System.Windows.Forms.SplitContainer();
        btnInfoSelection = new System.Windows.Forms.Button();
        btnInfoInsertion = new System.Windows.Forms.Button();
        btnInfoQuick = new System.Windows.Forms.Button();
        btnInfoMerge = new System.Windows.Forms.Button();
        btnInfoHeap = new System.Windows.Forms.Button();
        btnInfoBubble = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackSpeed).BeginInit();
        ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
        splitContainer.Panel1.SuspendLayout();
        splitContainer.Panel2.SuspendLayout();
        splitContainer.SuspendLayout();
        SuspendLayout();
        // 
        // btnGenerate
        // 
        btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
        btnGenerate.Cursor = System.Windows.Forms.Cursors.IBeam;
        btnGenerate.Location = new System.Drawing.Point(12, 254);
        btnGenerate.Name = "btnGenerate";
        btnGenerate.Size = new System.Drawing.Size(120, 46);
        btnGenerate.TabIndex = 1;
        btnGenerate.Text = "Generate";
        btnGenerate.UseVisualStyleBackColor = false;
        // 
        // btnStart
        // 
        btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
        btnStart.CausesValidation = false;
        btnStart.Location = new System.Drawing.Point(12, 319);
        btnStart.Name = "btnStart";
        btnStart.Size = new System.Drawing.Size(120, 46);
        btnStart.TabIndex = 2;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = false;
        // 
        // btnStop
        // 
        btnStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
        btnStop.Location = new System.Drawing.Point(12, 383);
        btnStop.Name = "btnStop";
        btnStop.Size = new System.Drawing.Size(120, 46);
        btnStop.TabIndex = 3;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = false;
        // 
        // numSize
        // 
        numSize.Location = new System.Drawing.Point(201, 402);
        numSize.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numSize.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
        numSize.Name = "numSize";
        numSize.Size = new System.Drawing.Size(120, 27);
        numSize.TabIndex = 5;
        numSize.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // trackSpeed
        // 
        trackSpeed.Location = new System.Drawing.Point(201, 277);
        trackSpeed.Maximum = 200;
        trackSpeed.Minimum = 1;
        trackSpeed.Name = "trackSpeed";
        trackSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        trackSpeed.Size = new System.Drawing.Size(104, 56);
        trackSpeed.TabIndex = 6;
        trackSpeed.Value = 20;
        // 
        // lbSize
        // 
        lbSize.AutoSize = true;
        lbSize.Location = new System.Drawing.Point(223, 379);
        lbSize.Name = "lbSize";
        lbSize.Size = new System.Drawing.Size(73, 20);
        lbSize.TabIndex = 7;
        lbSize.Text = "Array size";
        // 
        // lbSpeed
        // 
        lbSpeed.AutoSize = true;
        lbSpeed.Location = new System.Drawing.Point(223, 254);
        lbSpeed.Name = "lbSpeed";
        lbSpeed.Size = new System.Drawing.Size(51, 20);
        lbSpeed.TabIndex = 8;
        lbSpeed.Text = "Speed";
        // 
        // chkBubble
        // 
        chkBubble.Checked = true;
        chkBubble.CheckState = System.Windows.Forms.CheckState.Checked;
        chkBubble.Location = new System.Drawing.Point(12, 29);
        chkBubble.Name = "chkBubble";
        chkBubble.Size = new System.Drawing.Size(104, 24);
        chkBubble.TabIndex = 13;
        chkBubble.Text = "Bubble Sort";
        chkBubble.UseVisualStyleBackColor = false;
        // 
        // chkSelection
        // 
        chkSelection.Checked = true;
        chkSelection.CheckState = System.Windows.Forms.CheckState.Checked;
        chkSelection.Location = new System.Drawing.Point(12, 59);
        chkSelection.Name = "chkSelection";
        chkSelection.Size = new System.Drawing.Size(104, 24);
        chkSelection.TabIndex = 14;
        chkSelection.Text = "Selection Sort";
        chkSelection.UseVisualStyleBackColor = false;
        // 
        // chkInsertion
        // 
        chkInsertion.Checked = true;
        chkInsertion.CheckState = System.Windows.Forms.CheckState.Checked;
        chkInsertion.Location = new System.Drawing.Point(12, 89);
        chkInsertion.Name = "chkInsertion";
        chkInsertion.Size = new System.Drawing.Size(104, 24);
        chkInsertion.TabIndex = 15;
        chkInsertion.Text = "Insertion Sort";
        chkInsertion.UseVisualStyleBackColor = false;
        // 
        // chkHeap
        // 
        chkHeap.Checked = true;
        chkHeap.CheckState = System.Windows.Forms.CheckState.Checked;
        chkHeap.Location = new System.Drawing.Point(12, 179);
        chkHeap.Name = "chkHeap";
        chkHeap.Size = new System.Drawing.Size(104, 24);
        chkHeap.TabIndex = 16;
        chkHeap.Text = "Heap Sort";
        chkHeap.UseVisualStyleBackColor = false;
        // 
        // chkMerge
        // 
        chkMerge.Checked = true;
        chkMerge.CheckState = System.Windows.Forms.CheckState.Checked;
        chkMerge.Location = new System.Drawing.Point(12, 149);
        chkMerge.Name = "chkMerge";
        chkMerge.Size = new System.Drawing.Size(104, 24);
        chkMerge.TabIndex = 17;
        chkMerge.Text = "Merge Sort";
        chkMerge.UseVisualStyleBackColor = false;
        // 
        // chkQuick
        // 
        chkQuick.Checked = true;
        chkQuick.CheckState = System.Windows.Forms.CheckState.Checked;
        chkQuick.Location = new System.Drawing.Point(12, 119);
        chkQuick.Name = "chkQuick";
        chkQuick.Size = new System.Drawing.Size(104, 24);
        chkQuick.TabIndex = 18;
        chkQuick.Text = "Quick Sort";
        chkQuick.UseVisualStyleBackColor = false;
        // 
        // tablePanel
        // 
        tablePanel.AutoScroll = true;
        tablePanel.ColumnCount = 2;
        tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
        tablePanel.Location = new System.Drawing.Point(0, 0);
        tablePanel.Name = "tablePanel";
        tablePanel.RowCount = 2;
        tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tablePanel.Size = new System.Drawing.Size(837, 786);
        tablePanel.TabIndex = 19;
        // 
        // splitContainer
        // 
        splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer.Location = new System.Drawing.Point(0, 0);
        splitContainer.Name = "splitContainer";
        // 
        // splitContainer.Panel1
        // 
        splitContainer.Panel1.Controls.Add(btnInfoSelection);
        splitContainer.Panel1.Controls.Add(btnInfoInsertion);
        splitContainer.Panel1.Controls.Add(btnInfoQuick);
        splitContainer.Panel1.Controls.Add(btnInfoMerge);
        splitContainer.Panel1.Controls.Add(btnInfoHeap);
        splitContainer.Panel1.Controls.Add(btnInfoBubble);
        splitContainer.Panel1.Controls.Add(chkBubble);
        splitContainer.Panel1.Controls.Add(btnStop);
        splitContainer.Panel1.Controls.Add(lbSize);
        splitContainer.Panel1.Controls.Add(lbSpeed);
        splitContainer.Panel1.Controls.Add(chkHeap);
        splitContainer.Panel1.Controls.Add(chkMerge);
        splitContainer.Panel1.Controls.Add(trackSpeed);
        splitContainer.Panel1.Controls.Add(chkInsertion);
        splitContainer.Panel1.Controls.Add(chkQuick);
        splitContainer.Panel1.Controls.Add(chkSelection);
        splitContainer.Panel1.Controls.Add(btnGenerate);
        splitContainer.Panel1.Controls.Add(btnStart);
        splitContainer.Panel1.Controls.Add(numSize);
        // 
        // splitContainer.Panel2
        // 
        splitContainer.Panel2.Controls.Add(tablePanel);
        splitContainer.Size = new System.Drawing.Size(1260, 786);
        splitContainer.SplitterDistance = 419;
        splitContainer.TabIndex = 20;
        // 
        // btnInfoSelection
        // 
        btnInfoSelection.Location = new System.Drawing.Point(122, 57);
        btnInfoSelection.Name = "btnInfoSelection";
        btnInfoSelection.Size = new System.Drawing.Size(86, 26);
        btnInfoSelection.TabIndex = 24;
        btnInfoSelection.Text = "Info";
        btnInfoSelection.UseVisualStyleBackColor = true;
        // 
        // btnInfoInsertion
        // 
        btnInfoInsertion.Location = new System.Drawing.Point(122, 89);
        btnInfoInsertion.Name = "btnInfoInsertion";
        btnInfoInsertion.Size = new System.Drawing.Size(86, 26);
        btnInfoInsertion.TabIndex = 23;
        btnInfoInsertion.Text = "Info";
        btnInfoInsertion.UseVisualStyleBackColor = true;
        // 
        // btnInfoQuick
        // 
        btnInfoQuick.Location = new System.Drawing.Point(122, 121);
        btnInfoQuick.Name = "btnInfoQuick";
        btnInfoQuick.Size = new System.Drawing.Size(86, 26);
        btnInfoQuick.TabIndex = 22;
        btnInfoQuick.Text = "Info";
        btnInfoQuick.UseVisualStyleBackColor = true;
        // 
        // btnInfoMerge
        // 
        btnInfoMerge.Location = new System.Drawing.Point(122, 149);
        btnInfoMerge.Name = "btnInfoMerge";
        btnInfoMerge.Size = new System.Drawing.Size(86, 26);
        btnInfoMerge.TabIndex = 21;
        btnInfoMerge.Text = "Info";
        btnInfoMerge.UseVisualStyleBackColor = true;
        // 
        // btnInfoHeap
        // 
        btnInfoHeap.Location = new System.Drawing.Point(122, 181);
        btnInfoHeap.Name = "btnInfoHeap";
        btnInfoHeap.Size = new System.Drawing.Size(86, 26);
        btnInfoHeap.TabIndex = 20;
        btnInfoHeap.Text = "Info";
        btnInfoHeap.UseVisualStyleBackColor = true;
        // 
        // btnInfoBubble
        // 
        btnInfoBubble.Location = new System.Drawing.Point(122, 24);
        btnInfoBubble.Name = "btnInfoBubble";
        btnInfoBubble.Size = new System.Drawing.Size(86, 26);
        btnInfoBubble.TabIndex = 19;
        btnInfoBubble.Text = "Info";
        btnInfoBubble.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1260, 786);
        Controls.Add(splitContainer);
        Text = "MainForm";
        ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackSpeed).EndInit();
        splitContainer.Panel1.ResumeLayout(false);
        splitContainer.Panel1.PerformLayout();
        splitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
        splitContainer.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnInfoHeap;
    private System.Windows.Forms.Button btnInfoMerge;
    private System.Windows.Forms.Button btnInfoQuick;
    private System.Windows.Forms.Button btnInfoInsertion;
    private System.Windows.Forms.Button btnInfoSelection;

    private System.Windows.Forms.Button btnInfoBubble;

    private System.Windows.Forms.SplitContainer splitContainer;

    private System.Windows.Forms.TableLayoutPanel tablePanel;

    private System.Windows.Forms.CheckBox chkSelection;
    private System.Windows.Forms.CheckBox chkInsertion;
    private System.Windows.Forms.CheckBox chkHeap;
    private System.Windows.Forms.CheckBox chkMerge;
    private System.Windows.Forms.CheckBox chkQuick;

    private System.Windows.Forms.CheckBox chkBubble;

    private System.Windows.Forms.Label lbSpeed;

    private System.Windows.Forms.Label lbSize;

    private System.Windows.Forms.TrackBar trackSpeed;

    private System.Windows.Forms.NumericUpDown numSize;

    private System.Windows.Forms.Button btnStart;

    private System.Windows.Forms.Button btnStop;

    private System.Windows.Forms.Button btnGenerate;

    #endregion
}