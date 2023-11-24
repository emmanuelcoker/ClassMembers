using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers.Models
{

    interface IProduct
    {
        public void ShowProductDetails();
    }

    public class Product : IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public enum Brand
        {
            Nike = 0,
            Addidas = 1,
            Fendi = 3,
            Gucci = 4
        }

        public Brand productBrand { get; set; }
        public Product(string name, string desc, double price, Brand brand)
        {
            Name = name;
            Description = desc;
            Price = price;
            productBrand = brand;
        }

        public void ShowProductDetails()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Description: {Description}");
            Console.WriteLine($"Product Price: {Price}");
            Console.WriteLine($"Product Brand: {productBrand}");
        }


        //destructor
        ~Product() {
            Console.WriteLine("Destructor Called!");
        }



    }
}
