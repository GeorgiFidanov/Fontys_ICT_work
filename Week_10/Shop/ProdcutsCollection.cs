using System;
using System.Collections.Generic;

public class ProdcutsCollection
{
    private List<Product> products;

    public ProdcutsCollection()
    {
        this.products = new List<Product>();
    }

    public void AddProduct(string name, decimal price)
    {
        Product newProduct = new Product(name, price);
        products.Add(newProduct);
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }

    public Product? GetOneProduct(string name)
    {
        foreach (Product product in products)
        {
            if(product.GetName() == name)
            {
                return product;
            }
        }
        throw new Exception("Product now found");
    }
}

