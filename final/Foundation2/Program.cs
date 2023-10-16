using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4 Reina Victoria St", "Parla", "MDR", "Spain");
        Address address2 = new Address("6 San Roque Ave", "Sant Marti", "BCN", "Spain");
        Address address3 = new Address("7 Felipe II Rd", "Epinay", "PAR", "France");

        Customer customer1 = new Customer("Samuel Aguilar", address1);
        Customer customer2 = new Customer("Solange Cotacachi", address2);
        Customer customer3 = new Customer("Nefi Aguilar", address3);

        Product product1 = new Product("Iphone 14", "AP1", 1050, 2);
        Product product2 = new Product("Smartwatch", "SM1", 300, 3);
        Product product3 = new Product("Headphones", "HP1", 35, 4);

        Order[] orders = new Order[3];

        orders[0] = new Order(customer1);
        orders[0].AddProduct(product1);
        orders[0].AddProduct(product2);

        orders[1] = new Order(customer2);
        orders[1].AddProduct(product2);
        orders[1].AddProduct(product3);

        orders[2] = new Order(customer3);
        orders[2].AddProduct(product1);
        orders[2].AddProduct(product3);


        for (int i = 0; i < orders.Length; i++)
        {
            Console.WriteLine($"\n  --- ORDER {i + 1} ---\n");
            Console.WriteLine("\n-->Packing Label<--");
            Console.WriteLine(orders[i].GetPackagingLabel());
            Console.WriteLine("\n-->Shipping Label<--\n");
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Total price: {orders[i].CalculateTotalPrice()} \u20AC\n");
        }
    }
}
