namespace Finances
{
    public class Expense
    {
        private string name;
        private double amount;

        public void InitializeExpense(string name, double amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public string GetInfo()
        {
            return $"{name}: {amount:F2}";
        }

        public double Amount => amount;
    }
}
