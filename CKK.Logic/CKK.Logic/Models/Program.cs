
namespace CKK.Logic.Models
{
    public class Program
    {
        private static void Main(string[]args)
        {
            Customer bob = new Customer();
            bob.SetId(1);
            bob.SetName("John Doe");
            bob.SetAddress("123 Main St");
            bob.GetId();
            bob.GetName();
            bob.GetAddress();
            //Console.WriteLine($"Customer ID: {Bob.GetId()}");
            //Console.WriteLine($"Customer Name: {Bob.GetName()}");
            //Console.WriteLine($"Customer Address: {Bob.GetAddress()}");
            //Console.WriteLine();

            
            Product cheese = new Product();
            cheese.SetId(5005);
            cheese.SetName("Cheese");
            cheese.SetPrice((decimal)3.99);
            cheese.GetId();
            cheese.GetName();
            cheese.GetPrice();
            //Console.WriteLine($"Product ID: {Cheese.GetId()}");
            //Console.WriteLine($"Product Name: {Cheese.GetName()}");
            //Console.WriteLine($"Product Price: ${Cheese.GetPrice()}");
            //Console.WriteLine();

            StoreItem cheeseItem = new StoreItem(cheese, 123);
            cheeseItem.SetQuantity(142);
            cheeseItem.SetProduct(cheese);
            cheeseItem.GetProduct();
            cheeseItem.GetQuantity();
            //Console.WriteLine($"Product Name: {cheeseItem.GetProduct()}");
            //Console.WriteLine($"Product Quantity: {cheeseItem.GetQuantity()}");
            //Console.WriteLine();

            ShoppingCartItem cheeseShoppingCartItem = new ShoppingCartItem(cheese, 11);
            cheeseShoppingCartItem.SetQuantity(13);
            cheeseShoppingCartItem.SetProduct(cheese);
            cheeseShoppingCartItem.GetProduct();
            cheeseShoppingCartItem.GetQuantity();
            //Console.WriteLine($"Product Name: {cheeseShoppingCartItem.GetProduct()}");
            //Console.WriteLine($"Product Quantity: {cheeseShoppingCartItem.GetQuantity()}");
            //Console.WriteLine();


           
        }
    }
}


