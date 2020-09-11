using System;
using System.Globalization;
using System.Collections.Generic;

namespace list_FUNC
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("How many employees will be registred:  ");
            int p = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 0; i <= p; i++ ){
                System.Console.WriteLine("Register the employee Id: ");
                int id = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Register the name of employee: ");
                string name = Console.ReadLine();

                System.Console.WriteLine("Registe the salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                list.Add(new Employee(id, name, salary));
                System.Console.WriteLine();
            }

            System.Console.WriteLine("Enter the employee id will have salary encrease: ");
            int searchID = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchID);
            if(emp != null){
                System.Console.WriteLine("Enter the porsentage: ");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                

                emp.EncreaseSalary(porcentage);
            }else{
                System.Console.WriteLine("Id not exist");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("List of employees: ");
            foreach(Employee func in list){
                System.Console.WriteLine(func);
            }
            
        }
    }
}
