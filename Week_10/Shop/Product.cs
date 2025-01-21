using System;

public class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public string GetInfo()
    {
        return $"{name}: {price:F2}euros";
    }

    public List<decimal> GetFututeAnalysis(int inflation, decimal limit)
    {
        List<decimal> progression = new List<decimal>();
        while(price < limit)
        {
            price *= inflation; //not sure if i should devide by 100
            progression.Add(price);
        }
        return progression;

    }
}
