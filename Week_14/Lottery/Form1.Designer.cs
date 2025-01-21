namespace Lottery
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.TextBox numberOfNumbersTextBox;
        private System.Windows.Forms.TextBox maxValueTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label numberOfNumbersLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            drawButton = new Button();
            numberOfNumbersTextBox = new TextBox();
            maxValueTextBox = new TextBox();
            resetButton = new Button();
            maxValueLabel = new Label();
            numberOfNumbersLabel = new Label();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            drawNextButton = new Button();
            setButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // drawButton
            // 
            drawButton.Location = new Point(12, 171);
            drawButton.Margin = new Padding(4, 5, 4, 5);
            drawButton.Name = "drawButton";
            drawButton.Size = new Size(267, 35);
            drawButton.TabIndex = 1;
            drawButton.Text = "Draw all at once";
            drawButton.UseVisualStyleBackColor = true;
            drawButton.Click += drawButton_Click;
            // 
            // numberOfNumbersTextBox
            // 
            numberOfNumbersTextBox.Location = new Point(0, 108);
            numberOfNumbersTextBox.Margin = new Padding(4, 5, 4, 5);
            numberOfNumbersTextBox.Name = "numberOfNumbersTextBox";
            numberOfNumbersTextBox.Size = new Size(198, 27);
            numberOfNumbersTextBox.TabIndex = 2;
            // 
            // maxValueTextBox
            // 
            maxValueTextBox.Location = new Point(0, 59);
            maxValueTextBox.Margin = new Padding(4, 5, 4, 5);
            maxValueTextBox.Name = "maxValueTextBox";
            maxValueTextBox.Size = new Size(198, 27);
            maxValueTextBox.TabIndex = 3;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(12, 263);
            resetButton.Margin = new Padding(4, 5, 4, 5);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(267, 35);
            resetButton.TabIndex = 4;
            resetButton.Text = "Reset Lottery";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // maxValueLabel
            // 
            maxValueLabel.AutoSize = true;
            maxValueLabel.Location = new Point(0, 34);
            maxValueLabel.Margin = new Padding(4, 0, 4, 0);
            maxValueLabel.Name = "maxValueLabel";
            maxValueLabel.Size = new Size(80, 20);
            maxValueLabel.TabIndex = 5;
            maxValueLabel.Text = "Max Value:";
            // 
            // numberOfNumbersLabel
            // 
            numberOfNumbersLabel.AutoSize = true;
            numberOfNumbersLabel.Location = new Point(0, 84);
            numberOfNumbersLabel.Margin = new Padding(4, 0, 4, 0);
            numberOfNumbersLabel.Name = "numberOfNumbersLabel";
            numberOfNumbersLabel.Size = new Size(198, 20);
            numberOfNumbersLabel.TabIndex = 6;
            numberOfNumbersLabel.Text = "Number of wanted numbers:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(286, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 284);
            listBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(setButton);
            groupBox1.Controls.Add(maxValueLabel);
            groupBox1.Controls.Add(numberOfNumbersTextBox);
            groupBox1.Controls.Add(numberOfNumbersLabel);
            groupBox1.Controls.Add(maxValueTextBox);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 147);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottery Settings";
            // 
            // drawNextButton
            // 
            drawNextButton.Location = new Point(12, 216);
            drawNextButton.Margin = new Padding(4, 5, 4, 5);
            drawNextButton.Name = "drawNextButton";
            drawNextButton.Size = new Size(267, 37);
            drawNextButton.TabIndex = 9;
            drawNextButton.Text = "Draw next number";
            drawNextButton.UseVisualStyleBackColor = true;
            drawNextButton.Click += drawNextButton_Click;
            // 
            // setButton
            // 
            setButton.Location = new Point(205, 59);
            setButton.Name = "setButton";
            setButton.Size = new Size(63, 76);
            setButton.TabIndex = 7;
            setButton.Text = "Set info";
            setButton.UseVisualStyleBackColor = true;
            setButton.Click += setButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 304);
            Controls.Add(drawNextButton);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(drawButton);
            Controls.Add(resetButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Lottery";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private ListBox listBox1;
        private GroupBox groupBox1;
        private Button drawNextButton;
        private Button setButton;
    }
}
