using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_2
{
    internal class Company
    {
        public string name;
        public Emplooye[] emplooyes;
        private int counter;
        public Company()
        {
            name = "Talha's Motors";
            emplooyes = new Emplooye[10];
            counter = 0;
        }

        public void addemp(Emplooye e1)
        {
            emplooyes[counter++] = e1;
            Console.WriteLine($"Employee {e1.firstname} is addedd to the company.\n Happy working !! ");

        }

        public void disp()
        {
            Console.WriteLine("\n\tEmployeees");
            for(int i = 0; i < counter; i++)
            {
                Console.WriteLine($"\nID = {emplooyes[i].id}");
                Console.WriteLine($"First Name = {emplooyes[i].firstname}");
                Console.WriteLine($"Last Name = {emplooyes[i].lastname}");
                Console.WriteLine($"Date of Birth = {emplooyes[i].dateofbirth}");
                Console.WriteLine($"Salary = {emplooyes[i].salary}");
                Console.WriteLine($"Department = {emplooyes[i].dep}");

            }
        }

        public void dispemp(int id)
        {
            Console.WriteLine("\n\tSpecific Employeee");
            for (int i = 0; i < counter; i++)
            {
                
                if (emplooyes[i].id == id)
                {
                    Console.WriteLine($"\nID = {emplooyes[i].id}");
                    Console.WriteLine($"First Name = {emplooyes[i].firstname}");
                    Console.WriteLine($"Last Name = {emplooyes[i].lastname}");
                    Console.WriteLine($"Date of Birth = {emplooyes[i].dateofbirth}");
                    Console.WriteLine($"Salary = {emplooyes[i].salary}");
                    Console.WriteLine($"Department = {emplooyes[i].dep}");
                }
                
            }

        }

        public void remove(Emplooye e1)
        {
            for (int i = 0; i < counter; i++)
            {
                if (emplooyes[i].id == e1.id)
                {
                    
                    for (int j = i; j < counter - 1; j++)
                    {
                        emplooyes[j] = emplooyes[j + 1];
                    }

                    emplooyes[counter - 1] = null;
                    counter--; 
                    Console.WriteLine($"Employee with ID {e1.id} removed successfully.");
                    
                }
            }
            Console.WriteLine("\n\tUpdated List");
            disp();
        }

    }
}
