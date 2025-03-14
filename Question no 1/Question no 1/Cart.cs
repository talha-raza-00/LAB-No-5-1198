using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Cart
    {
        public int cartid;
        public string customername;
        public double totalprice;
        public Product[] products;
        private int counter;

        public Cart()
        {
            cartid = 000;
            customername = string.Empty;
            totalprice = 0;
            products = new Product[100];
            counter = 0;
        }

        public Cart(int id,string name)
        {
            cartid=id;
            customername = name;
            products = new Product[100];
        }

        public void addproduct(Product p1)
        {
            products[counter++] = p1;
            totalprice += p1.price;
            Console.WriteLine($"Product {p1.name} is added to Cart and total price is : {totalprice} ");
        }

        public void diplaycart()
        {
            Console.WriteLine("\n\n\tCART");
            Console.WriteLine($"Cart ID = {cartid}");
            Console.WriteLine($"Customer name = {customername}");
            for (int i=0 ; i<counter; i++)
            {
                Console.WriteLine($"\nproduct no {i+1}");
                Console.WriteLine($"ID = {products[i].ID}");
                Console.WriteLine($"Name = {products[i].name}");
                Console.WriteLine($"Price = {products[i].price}");


            }
            Console.WriteLine("\n\tTotal Price = {0}",totalprice);
        }

        public void remove(Product p1)
        {
            for (int i = 0; i < counter; i++)
            {
                if( products[i].ID == p1.ID)
                {
                    Console.WriteLine($"\nThe product {p1.name} is removed !!");
                    totalprice -= products[i].price;
                    Console.WriteLine($"The total price is now = {totalprice}");
                }
            }
        }


    }
}
