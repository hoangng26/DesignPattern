using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define each products in an iPhone 14 box
            var phone = new Product(1, "iPhone 14", 950);
            var lightningCable = new Product(2, "USB Type-C to Lightning Cable", 15);
            var charger = new Product(3, "Fast Charger 20W Type-C", 15);
            var earPods = new Product(4, "EarPods with Lightning", 19);
            var receipt = new Product(5, "Receipt", 0);

            // Case 1: Define a new box and add all products into it directly.
            /*Box box = new Box();
            box.setName("Iphone 14 Full Box VN/A");
            box.addComponent(phone);
            box.addComponent(lightningCable);
            box.addComponent(charger);
            box.addComponent(earPods);
            box.addComponent(receipt);*/

            // Case 2: Define a new box and add all product into it with a list item.
            /*var listItem = new List<Component>();
            listItem.Add(phone);
            listItem.Add(lightningCable);
            listItem.Add(charger);
            listItem.Add(earPods);
            listItem.Add(receipt);
            Box box = new Box(2603, "iPhone 14 Full Box VN/A", listItem);*/

            /* Case 3: Define a new box and add all products into it, 
             *         including some products, some little boxes and some big boxes.
             */
            // Define a phone box including iPhone 14.
            var phoneBox = new Box(101, "Phone Box");
            phoneBox.addComponent(phone);
            // Define a charger box including lightning cable and charger.
            var chargerBox = new Box(102, "Charger Box");
            chargerBox.addComponent(lightningCable);
            chargerBox.addComponent(charger);
            // Define an earphones box including earpods.
            var earphonesBox = new Box(103, "Earphone Box");
            earphonesBox.addComponent(earPods);
            // Define an accessories box including charger box and earphones box.
            var accessoriesBox = new Box(999, "Accessories Box");
            accessoriesBox.addComponent(chargerBox);
            accessoriesBox.addComponent(earphonesBox);
            // Define a new box and add all boxes, all products into it.
            Box box = new Box(2603, "iPhone 14 Full Box VN/A");
            box.addComponent(phoneBox);
            box.addComponent(accessoriesBox);
            box.addComponent(receipt);

            // Result when call function box.getPrice() to get price of all products, all boxes in the box.
            Console.WriteLine(box.getPrice());
        }
    }
}
