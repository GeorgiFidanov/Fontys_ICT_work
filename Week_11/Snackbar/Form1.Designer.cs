namespace Snackbar
{
    partial class Form1
    {
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.Button btnUpdateSnack;

        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            btnOrder = new Button();
            btnRevenue = new Button();
            lblResult = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownStock = new NumericUpDown();
            btnUpdateSnack = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 12);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(12, 38);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(12, 64);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 2;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(12, 90);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(120, 23);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnRevenue
            // 
            btnRevenue.Location = new Point(12, 119);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new Size(120, 23);
            btnRevenue.TabIndex = 4;
            btnRevenue.Text = "Show Revenue";
            btnRevenue.UseVisualStyleBackColor = true;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 145);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(176, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Chips";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(176, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Chocolate";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(176, 64);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Soda";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(176, 90);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 9;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(176, 116);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 10;
            // 
            // btnUpdateSnack
            // 
            btnUpdateSnack.Location = new Point(176, 142);
            btnUpdateSnack.Name = "btnUpdateSnack";
            btnUpdateSnack.Size = new Size(120, 23);
            btnUpdateSnack.TabIndex = 11;
            btnUpdateSnack.Text = "Update Snack";
            btnUpdateSnack.UseVisualStyleBackColor = true;
            btnUpdateSnack.Click += btnUpdateSnack_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(303, 179);
            Controls.Add(btnUpdateSnack);
            Controls.Add(numericUpDownStock);
            Controls.Add(numericUpDownPrice);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lblResult);
            Controls.Add(btnRevenue);
            Controls.Add(btnOrder);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "MacSnack";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
