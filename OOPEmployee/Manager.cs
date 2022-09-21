using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEmployee
{
    internal class Manager: Employee
    {
        public Manager()
        {

        }

        public Manager(string employeeCode, string name, int baseSalary, double levelNumber, DateTime onboardDate)
        {
            this.EmployeeCode = employeeCode;
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.LevelNumber = levelNumber;
            this.OnboardDate = onboardDate;
        }

        public override void Position()
        {
            Console.WriteLine("Position Manager");
        }
    }
}
