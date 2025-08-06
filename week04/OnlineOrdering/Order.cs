using System;
using System.Text;
// This class represents an order, which contains a customer and a list of products.
// It orchestrates the logic for calculating cost and generating labels.
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const double USA_SHIPPING_COST = 5.00;
    private const double INTERNATIONAL_SHIPPING_COST = 35.00;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates the total cost of the order, including products and shipping.
    public double CalculateTotalCost()
    {
        double totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.IsUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;

        return totalProductCost + shippingCost;
    }

    // Generates a packing label string.
    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("--- Packing Label ---");
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"Product: {product.GetName()}, ID: {product.GetProductId()}");
        }
        return packingLabel.ToString();
    }

    // Generates a shipping label string.
    public string GetShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();
        shippingLabel.AppendLine("--- Shipping Label ---");
        shippingLabel.AppendLine($"Customer Name: {_customer.GetName()}");
        shippingLabel.AppendLine($"Address:\n{_customer.GetAddress().GetFullAddress()}");
        return shippingLabel.ToString();
    }
}
