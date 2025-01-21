namespace Finances
{
    public partial class Form1 : Form
    {
        private List<Expense> transactionLog;

        public Form1()
        {
            InitializeComponent();
            transactionLog = new List<Expense>();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string name = txtExpenseName.Text;
            double amount = (double)numExpenseAmount.Value;

            Expense expense = new Expense();
            expense.InitializeExpense(name, amount);
            transactionLog.Add(expense);

            txtExpenseName.Clear();
            numExpenseAmount.Value = 0;
        }

        private void btnShowAllExpenses_Click(object sender, EventArgs e)
        {
            lstExpenses.Items.Clear();
            foreach (var expense in transactionLog)
            {
                lstExpenses.Items.Add(expense.GetInfo());
            }
        }

        private void btnShowExpensesWithAmount_Click(object sender, EventArgs e)
        {
            string name = "Compare";
            double amount = (double)numericUpDown1.Value;
            lstExpenses.Items.Clear();

            Expense filter = new Expense();
            filter.InitializeExpense(name, amount);

            foreach (var expense in transactionLog)
            {
                if (expense.Amount >= amount)
                {
                    lstExpenses.Items.Add(expense.GetInfo());
                }
            }
        }
    }
}
