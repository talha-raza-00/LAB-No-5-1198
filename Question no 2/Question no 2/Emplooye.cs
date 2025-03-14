using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_2
{
    internal class Emplooye
    {
        public int id;
        public string firstname;
        public string lastname;
        public int dateofbirth;
        public double salary;
        public string dep;

        public Emplooye(int id,string fn,string ln,int date,double sal,string dep)
        {
            this.id = id;
            this.firstname = fn;
            this.lastname = ln;
            this.dateofbirth = date;
            this.salary = sal;
            this.dep = dep;
        }



    }
}
