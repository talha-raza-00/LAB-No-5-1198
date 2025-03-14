using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(001,"apples",265.5);
            Product p2 = new Product(002, "banana", 185.5);
            Product p3 = new Product(003, "dates", 185.9);
            Product p4 = new Product(004, "Rose water", 165.3);
            Product p5 = new Product(005, "Cake", 126.5);

            Cart c1 = new Cart(10232, "Talha");
            c1.addproduct(p1);
            c1.addproduct(p2);
            c1.addproduct(p3);
            c1.addproduct(p4);
            c1.addproduct(p5);

            c1.diplaycart();
            c1.remove(p1);



        }
    }
}
