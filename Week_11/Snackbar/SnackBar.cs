using System.Collections.Generic;

public class SnackBar
{
    private List<Snack> snacks;
    private double revenue;

    public SnackBar()
    {
        snacks = new List<Snack>();
        revenue = 0;
    }

    public void AddSnack(Snack snack)
    {
        snacks.Add(snack);
    }

    public double ProcessOrder(int[] amounts, out List<string> outOfStockSnacks)
    {
        outOfStockSnacks = new List<string>();
        double total = 0;

        // Check stock availability first
        for (int i = 0; i < snacks.Count; i++)
        {
            if (snacks[i].GetAmountInStock() < amounts[i])
            {
                outOfStockSnacks.Add(snacks[i].GetName());
            }
        }

        if (outOfStockSnacks.Count > 0)
        {
            return -1;
        }

        // If all items are available, decrease stock and calculate total
        for (int i = 0; i < snacks.Count; i++)
        {
            snacks[i].DecreaseStock(amounts[i]);
            total += amounts[i] * snacks[i].GetPrice();
        }

        revenue += total;
        return total;
    }

    public double GetRevenue()
    {
        return revenue;
    }

    public List<Snack> GetSnacks()
    {
        return snacks;
    }
}
