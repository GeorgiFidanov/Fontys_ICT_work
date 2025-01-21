namespace Finances
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.NumericUpDown numExpenseAmount;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnShowAllExpenses;
        private System.Windows.Forms.Button btnShowExpensesWithAmount;
        private System.Windows.Forms.ListBox lstExpenses;

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
            txtExpenseName = new TextBox();
            numExpenseAmount = new NumericUpDown();
            btnAddExpense = new Button();
            btnShowAllExpenses = new Button();
            btnShowExpensesWithAmount = new Button();
            lstExpenses = new ListBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(12, 37);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.PlaceholderText = "Name";
            txtExpenseName.Size = new Size(200, 23);
            txtExpenseName.TabIndex = 0;
            // 
            // numExpenseAmount
            // 
            numExpenseAmount.DecimalPlaces = 2;
            numExpenseAmount.Location = new Point(66, 66);
            numExpenseAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numExpenseAmount.Name = "numExpenseAmount";
            numExpenseAmount.Size = new Size(146, 23);
            numExpenseAmount.TabIndex = 1;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(12, 95);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(200, 23);
            btnAddExpense.TabIndex = 2;
            btnAddExpense.Text = "Add Expense to Log";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // btnShowAllExpenses
            // 
            btnShowAllExpenses.Location = new Point(12, 124);
            btnShowAllExpenses.Name = "btnShowAllExpenses";
            btnShowAllExpenses.Size = new Size(200, 23);
            btnShowAllExpenses.TabIndex = 3;
            btnShowAllExpenses.Text = "Show All Expenses";
            btnShowAllExpenses.UseVisualStyleBackColor = true;
            btnShowAllExpenses.Click += btnShowAllExpenses_Click;
            // 
            // btnShowExpensesWithAmount
            // 
            btnShowExpensesWithAmount.Location = new Point(12, 241);
            btnShowExpensesWithAmount.Name = "btnShowExpensesWithAmount";
            btnShowExpensesWithAmount.Size = new Size(200, 23);
            btnShowExpensesWithAmount.TabIndex = 4;
            btnShowExpensesWithAmount.Text = "Show Filtered Expenses";
            btnShowExpensesWithAmount.UseVisualStyleBackColor = true;
            btnShowExpensesWithAmount.Click += btnShowExpensesWithAmount_Click;
            // 
            // lstExpenses
            // 
            lstExpenses.FormattingEnabled = true;
            lstExpenses.ItemHeight = 15;
            lstExpenses.Location = new Point(256, 12);
            lstExpenses.Name = "lstExpenses";
            lstExpenses.Size = new Size(200, 289);
            lstExpenses.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Expense form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Amount";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(66, 212);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(146, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 214);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 179);
            label4.Name = "label4";
            label4.Size = new Size(180, 30);
            label4.TabIndex = 10;
            label4.Text = "Filter expenses with amounts:\r\nequal or higher of your choosing";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 321);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstExpenses);
            Controls.Add(btnShowExpensesWithAmount);
            Controls.Add(btnShowAllExpenses);
            Controls.Add(btnAddExpense);
            Controls.Add(numExpenseAmount);
            Controls.Add(txtExpenseName);
            Name = "Form1";
            Text = "Finances";
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
    }
}
