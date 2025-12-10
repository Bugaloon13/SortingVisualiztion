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
        panelDisplay = new System.Windows.Forms.Panel();
        btnGenerate = new System.Windows.Forms.Button();
        btnStart = new System.Windows.Forms.Button();
        btnStop = new System.Windows.Forms.Button();
        comboAlgorithms = new System.Windows.Forms.ComboBox();
        numSize = new System.Windows.Forms.NumericUpDown();
        trackSpeed = new System.Windows.Forms.TrackBar();
        lbSize = new System.Windows.Forms.Label();
        lbSpeed = new System.Windows.Forms.Label();
        lblComparisons = new System.Windows.Forms.Label();
        lblSwaps = new System.Windows.Forms.Label();
        lblWrites = new System.Windows.Forms.Label();
        btnCompare = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackSpeed).BeginInit();
        SuspendLayout();
        // 
        // panelDisplay
        // 
        panelDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        panelDisplay.Location = new System.Drawing.Point(125, 6);
        panelDisplay.Name = "panelDisplay";
        panelDisplay.Size = new System.Drawing.Size(523, 240);
        panelDisplay.TabIndex = 0;
        // 
        // btnGenerate
        // 
        btnGenerate.Cursor = System.Windows.Forms.Cursors.IBeam;
        btnGenerate.Location = new System.Drawing.Point(70, 377);
        btnGenerate.Name = "btnGenerate";
        btnGenerate.Size = new System.Drawing.Size(99, 46);
        btnGenerate.TabIndex = 1;
        btnGenerate.Text = "Generate";
        btnGenerate.UseVisualStyleBackColor = true;
        // 
        // btnStart
        // 
        btnStart.CausesValidation = false;
        btnStart.Location = new System.Drawing.Point(318, 377);
        btnStart.Name = "btnStart";
        btnStart.Size = new System.Drawing.Size(99, 46);
        btnStart.TabIndex = 2;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        // 
        // btnStop
        // 
        btnStop.Location = new System.Drawing.Point(607, 377);
        btnStop.Name = "btnStop";
        btnStop.Size = new System.Drawing.Size(99, 46);
        btnStop.TabIndex = 3;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = true;
        // 
        // comboAlgorithms
        // 
        comboAlgorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboAlgorithms.FormattingEnabled = true;
        comboAlgorithms.Location = new System.Drawing.Point(125, 267);
        comboAlgorithms.Name = "comboAlgorithms";
        comboAlgorithms.Size = new System.Drawing.Size(121, 28);
        comboAlgorithms.TabIndex = 4;
        // 
        // numSize
        // 
        numSize.Location = new System.Drawing.Point(318, 268);
        numSize.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numSize.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
        numSize.Name = "numSize";
        numSize.Size = new System.Drawing.Size(120, 27);
        numSize.TabIndex = 5;
        numSize.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // trackSpeed
        // 
        trackSpeed.Location = new System.Drawing.Point(544, 252);
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
        lbSize.Location = new System.Drawing.Point(318, 298);
        lbSize.Name = "lbSize";
        lbSize.Size = new System.Drawing.Size(73, 20);
        lbSize.TabIndex = 7;
        lbSize.Text = "Array size";
        // 
        // lbSpeed
        // 
        lbSpeed.AutoSize = true;
        lbSpeed.Location = new System.Drawing.Point(557, 298);
        lbSpeed.Name = "lbSpeed";
        lbSpeed.Size = new System.Drawing.Size(51, 20);
        lbSpeed.TabIndex = 8;
        lbSpeed.Text = "Speed";
        // 
        // lblComparisons
        // 
        lblComparisons.AutoSize = true;
        lblComparisons.Location = new System.Drawing.Point(654, 9);
        lblComparisons.Name = "lblComparisons";
        lblComparisons.Size = new System.Drawing.Size(110, 20);
        lblComparisons.TabIndex = 9;
        lblComparisons.Text = "Comparisons: 0";
        // 
        // lblSwaps
        // 
        lblSwaps.AutoSize = true;
        lblSwaps.Location = new System.Drawing.Point(654, 56);
        lblSwaps.Name = "lblSwaps";
        lblSwaps.Size = new System.Drawing.Size(66, 20);
        lblSwaps.TabIndex = 10;
        lblSwaps.Text = "Swaps: 0";
        // 
        // lblWrites
        // 
        lblWrites.AutoSize = true;
        lblWrites.Location = new System.Drawing.Point(654, 92);
        lblWrites.Name = "lblWrites";
        lblWrites.Size = new System.Drawing.Size(66, 20);
        lblWrites.TabIndex = 11;
        lblWrites.Text = "Writes: 0";
        // 
        // btnCompare
        // 
        btnCompare.Location = new System.Drawing.Point(12, 21);
        btnCompare.Name = "btnCompare";
        btnCompare.Size = new System.Drawing.Size(104, 42);
        btnCompare.TabIndex = 12;
        btnCompare.Text = "CompareAll";
        btnCompare.UseVisualStyleBackColor = true;
        btnCompare.Click += btnCompare_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnCompare);
        Controls.Add(lblWrites);
        Controls.Add(lblSwaps);
        Controls.Add(lblComparisons);
        Controls.Add(lbSpeed);
        Controls.Add(lbSize);
        Controls.Add(trackSpeed);
        Controls.Add(numSize);
        Controls.Add(comboAlgorithms);
        Controls.Add(btnStop);
        Controls.Add(btnStart);
        Controls.Add(btnGenerate);
        Controls.Add(panelDisplay);
        Text = "MainForm";
        ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackSpeed).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnCompare;

    private System.Windows.Forms.Label lblWrites;

    private System.Windows.Forms.Label lblSwaps;

    private System.Windows.Forms.Label lblComparisons;

    private System.Windows.Forms.Label lbSpeed;

    private System.Windows.Forms.Label lbSize;

    private System.Windows.Forms.TrackBar trackSpeed;

    private System.Windows.Forms.NumericUpDown numSize;

    private System.Windows.Forms.ComboBox comboAlgorithms;

    private System.Windows.Forms.Button btnStart;

    private System.Windows.Forms.Button btnStop;

    private System.Windows.Forms.Button btnGenerate;

    private System.Windows.Forms.Panel panelDisplay;

    #endregion
}