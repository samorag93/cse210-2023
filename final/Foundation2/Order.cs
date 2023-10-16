using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetPrice();
        }
        total += _customer.GetShippingCost();
        return total;
    }

    public string GetPackagingLabel()
    {
        string label = "\nProducts:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} ({product.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Costumer: {_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
