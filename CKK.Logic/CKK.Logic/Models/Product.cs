
namespace CKK.Logic.Models
{
    public class Product
    {
        private int _id;
        private string _name = string.Empty;
        private decimal _price;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int uid)
        {
            _id = uid;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string uname)
        {
            _name = uname;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public void SetPrice(decimal uprice)
        {
            _price = uprice;
        }
    }
}