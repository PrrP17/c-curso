using System.Globalization;

namespace list_FUNC
{
    public class Employee
    {
        public int Id {get; set;}
        public string Name{get; set;}
        public double Salary{get; set;}

        public Employee (int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void EncreaseSalary(double porcentage){
            Salary += (Salary * (porcentage/100));
        }

        public override string ToString()
        {
            return Id
            + 
            ", " 
            + Name 
            +", "
            + Salary.ToString("F2", CultureInfo.InstalledUICulture);
        }
    }
}