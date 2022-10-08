using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Box : Component
    {
        private int _id;
        private string _name;
        private List<Component> _listComponents;
        public Box()
        {
            _id = 0;
            _name = "";
            _listComponents = new List<Component>();
        }
        public Box(int id, string name)
        {
            _id = id;
            _name = name;
            _listComponents = new List<Component>();
        }
        public Box(int id, string name, List<Component> listComponents)
        {
            _id = id;
            _name = name;
            _listComponents = listComponents;
        }
        public bool addComponent(Component component)
        {
            try
            {
                _listComponents.Add(component);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool removeComponentById(int id)
        {
            foreach (var component in _listComponents)
            {
                if (component.getId() == id)
                {
                    _listComponents.Remove(component);
                    return true;
                }
            }
            return false;
        }
        private int calcPrice()
        {
            var totalPrice = 0;
            foreach (var component in _listComponents)
            {
                totalPrice += component.getPrice();
            }
            return totalPrice;
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
            return calcPrice();
        }
    }
}
