public class Snack
{
    private string name;
    private double price;
    private int amountInStock;

    public Snack(string name, double price, int amountInStock)
    {
        this.name = name;
        this.price = price;
        this.amountInStock = amountInStock;
    }

    public bool DecreaseStock(int amount)
    {
        if (amountInStock >= amount)
        {
            amountInStock -= amount;
            return true;
        }
        return false;
    }

    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetAmountInStock()
    {
        return amountInStock;
    }

    public void UpdatePrice(double newPrice)
    {
        price = newPrice;
    }

    public void UpdateStock(int newStock)
    {
        amountInStock = newStock;
    }
}
