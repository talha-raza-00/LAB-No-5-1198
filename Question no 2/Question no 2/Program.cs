using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emplooye e1 = new Emplooye(101,"Talha","Raza",26,156897.26,"DCS");
            Emplooye e2 = new Emplooye(102, "Ali", "Amin", 23, 1254, "FBS");
            Emplooye e3 = new Emplooye(103, "Fahad", "Rasheed", 21, 10246.3, "FD");
            Emplooye e4 = new Emplooye(104, "Usama", "Raza", 12, 1218.3, "Textile");

            Company c1 = new Company();
            c1.addemp(e1);
            c1.addemp(e2);
            c1.addemp(e3);
            c1.addemp(e4);

            c1.disp();

            c1.dispemp(101);

            c1.remove(e1);
        }
    }
}
