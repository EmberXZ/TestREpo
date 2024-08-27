
namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;

        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int uquantity)
        {
            _quantity = uquantity;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public void SetProduct(Product uproduct)
        {
            _product = uproduct;
        }
    }
}