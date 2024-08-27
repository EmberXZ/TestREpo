
namespace CKK.Logic.Models
{
    public class Customer
    {
        private int _id;
        private string _name = string.Empty;
        private string _address = string.Empty;

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

        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string uaddress)
        {
            _address = uaddress;
        }
    }
}
