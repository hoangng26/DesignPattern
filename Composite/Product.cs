using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Product : Component
    {
        private int _id;
        private string _name;
        private int _price;
        public Product()
        {
            _id = 0;
            _name = "";
            _price = 0;
        }
        public Product(int id, string name, int price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public int getId()
        {
            return _id;
        }
        public bool setId(int id)
        {
            try
            {
                _id = id;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string getName()
        {
            return _name;
        }
        public bool setName(string name)
        {
            try
            {
                _name = name;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int getPrice()
        {
            return _price;
        }
        public bool setPrice(int price)
        {
            try
            {
                _price = price;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
