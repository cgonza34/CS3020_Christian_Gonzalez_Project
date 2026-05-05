namespace Christian_Gonzalez_Project
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumDice = new Label();
            lblNumSides = new Label();
            nudNumDice = new NumericUpDown();
            nudNumSides = new NumericUpDown();
            btnRoll = new Button();
            btnSave = new Button();
            rtbHistory = new RichTextBox();
            rtbStatistics = new RichTextBox();
            tableLayoutPanel = new TableLayoutPanel();
            lblHistory = new Label();
            lblStatistics = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNumDice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumSides).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumDice
            // 
            lblNumDice.Anchor = AnchorStyles.Right;
            lblNumDice.AutoSize = true;
            lblNumDice.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumDice.Location = new Point(138, 181);
            lblNumDice.Name = "lblNumDice";
            lblNumDice.Size = new Size(86, 39);
            lblNumDice.TabIndex = 0;
            lblNumDice.Text = "Dice:";
            // 
            // lblNumSides
            // 
            lblNumSides.Anchor = AnchorStyles.Right;
            lblNumSides.AutoSize = true;
            lblNumSides.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumSides.Location = new Point(124, 423);
            lblNumSides.Name = "lblNumSides";
            lblNumSides.Size = new Size(100, 39);
            lblNumSides.TabIndex = 1;
            lblNumSides.Text = "Sides:";
            // 
            // nudNumDice
            // 
            nudNumDice.Anchor = AnchorStyles.Left;
            nudNumDice.BackColor = Color.AliceBlue;
            nudNumDice.Cursor = Cursors.IBeam;
            nudNumDice.Font = new Font("Malgun Gothic", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudNumDice.Location = new Point(230, 179);
            nudNumDice.Name = "nudNumDice";
            nudNumDice.Size = new Size(211, 43);
            nudNumDice.TabIndex = 2;
            nudNumDice.TextAlign = HorizontalAlignment.Right;
            nudNumDice.ValueChanged += nudNumDice_ValueChanged;
            // 
            // nudNumSides
            // 
            nudNumSides.Anchor = AnchorStyles.Left;
            nudNumSides.BackColor = Color.AliceBlue;
            nudNumSides.Cursor = Cursors.IBeam;
            nudNumSides.Font = new Font("Malgun Gothic", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudNumSides.Location = new Point(230, 421);
            nudNumSides.Name = "nudNumSides";
            nudNumSides.Size = new Size(211, 43);
            nudNumSides.TabIndex = 3;
            nudNumSides.TextAlign = HorizontalAlignment.Right;
            nudNumSides.ValueChanged += nudNumSides_ValueChanged;
            // 
            // btnRoll
            // 
            btnRoll.Anchor = AnchorStyles.None;
            btnRoll.BackColor = Color.DarkOrange;
            btnRoll.Cursor = Cursors.Hand;
            btnRoll.FlatAppearance.BorderColor = Color.DarkOrange;
            btnRoll.FlatAppearance.BorderSize = 10;
            btnRoll.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnRoll.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnRoll.FlatStyle = FlatStyle.Flat;
            btnRoll.Font = new Font("Corbel", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRoll.Location = new Point(689, 136);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(249, 130);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll!";
            btnRoll.UseVisualStyleBackColor = false;
            btnRoll.Click += btnRoll_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.DarkOrange;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.DarkOrange;
            btnSave.FlatAppearance.BorderSize = 10;
            btnSave.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Corbel", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(689, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(249, 130);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save History";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // rtbHistory
            // 
            rtbHistory.BackColor = Color.AliceBlue;
            rtbHistory.Cursor = Cursors.IBeam;
            rtbHistory.Dock = DockStyle.Fill;
            rtbHistory.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbHistory.Location = new Point(1176, 83);
            rtbHistory.Name = "rtbHistory";
            rtbHistory.ReadOnly = true;
            tableLayoutPanel.SetRowSpan(rtbHistory, 4);
            rtbHistory.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbHistory.Size = new Size(715, 923);
            rtbHistory.TabIndex = 6;
            rtbHistory.Text = "";
            // 
            // rtbStatistics
            // 
            rtbStatistics.BackColor = Color.AliceBlue;
            tableLayoutPanel.SetColumnSpan(rtbStatistics, 3);
            rtbStatistics.Cursor = Cursors.IBeam;
            rtbStatistics.Dock = DockStyle.Fill;
            rtbStatistics.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbStatistics.Location = new Point(3, 647);
            rtbStatistics.Name = "rtbStatistics";
            rtbStatistics.ReadOnly = true;
            rtbStatistics.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbStatistics.Size = new Size(1167, 359);
            rtbStatistics.TabIndex = 7;
            rtbStatistics.Text = "";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel.Controls.Add(rtbStatistics, 0, 4);
            tableLayoutPanel.Controls.Add(nudNumSides, 1, 2);
            tableLayoutPanel.Controls.Add(lblNumSides, 0, 2);
            tableLayoutPanel.Controls.Add(nudNumDice, 1, 1);
            tableLayoutPanel.Controls.Add(btnRoll, 2, 1);
            tableLayoutPanel.Controls.Add(btnSave, 2, 2);
            tableLayoutPanel.Controls.Add(rtbHistory, 3, 1);
            tableLayoutPanel.Controls.Add(lblHistory, 3, 0);
            tableLayoutPanel.Controls.Add(lblStatistics, 0, 3);
            tableLayoutPanel.Controls.Add(lblNumDice, 0, 1);
            tableLayoutPanel.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1894, 1009);
            tableLayoutPanel.TabIndex = 8;
            // 
            // lblHistory
            // 
            lblHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Corbel", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistory.Location = new Point(1176, 35);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(148, 45);
            lblHistory.TabIndex = 8;
            lblHistory.Text = "History:";
            // 
            // lblStatistics
            // 
            lblStatistics.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatistics.AutoSize = true;
            lblStatistics.Font = new Font("Corbel", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatistics.Location = new Point(3, 599);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new Size(179, 45);
            lblStatistics.TabIndex = 9;
            lblStatistics.Text = "Statistics:";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.SteelBlue;
            tableLayoutPanel.SetColumnSpan(lblTitle, 3);
            lblTitle.Font = new Font("Corbel", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(786, 59);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Welcome to the dice-rolling simulator!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1894, 1009);
            Controls.Add(tableLayoutPanel);
            MinimumSize = new Size(640, 480);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudNumDice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumSides).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNumDice;
        private Label lblNumSides;
        private NumericUpDown nudNumDice;
        private NumericUpDown nudNumSides;
        private Button btnRoll;
        private Button btnSave;
        private RichTextBox rtbHistory;
        private RichTextBox rtbStatistics;
        private TableLayoutPanel tableLayoutPanel;
        private Label lblHistory;
        private Label lblStatistics;
        private Label lblTitle;
    }
}
