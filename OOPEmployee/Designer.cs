using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEmployee
{
    internal class Designer : Employee
    {
        public Designer()
        {

        }

        public Designer(string employeeCode, string name, int baseSalary, double levelNumber, DateTime onboardDate)
        {
            this.EmployeeCode = employeeCode;
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.LevelNumber = levelNumber;
            this.OnboardDate = onboardDate;
        }

        public override void Position()
        {
            Console.WriteLine("Position Designer");
        }
    }
}
