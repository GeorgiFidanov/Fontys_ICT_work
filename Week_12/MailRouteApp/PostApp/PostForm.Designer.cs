namespace PostApp
{
    partial class PostForm
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
            labelNumber = new Label();
            textBoxNumber = new TextBox();
            buttonOrder = new Button();
            listBoxNumbers = new ListBox();
            SuspendLayout();
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(32, 33);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(171, 25);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "Number of houses:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(209, 30);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(69, 32);
            textBoxNumber.TabIndex = 1;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(45, 87);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(224, 43);
            buttonOrder.TabIndex = 2;
            buttonOrder.Text = "Post delivery order";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.ItemHeight = 25;
            listBoxNumbers.Location = new Point(124, 156);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(69, 254);
            listBoxNumbers.TabIndex = 3;
            // 
            // PostForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 446);
            Controls.Add(listBoxNumbers);
            Controls.Add(buttonOrder);
            Controls.Add(textBoxNumber);
            Controls.Add(labelNumber);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "PostForm";
            Text = "Post application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumber;
        private TextBox textBoxNumber;
        private Button buttonOrder;
        private ListBox listBoxNumbers;
    }
}