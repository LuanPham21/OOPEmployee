using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEmployee
{
    internal abstract class Employee
    {
        protected string EmployeeCode { get; set; }
        protected string Name { get; set; }
        protected int BaseSalary { get; set; }
        protected double LevelNumber { get; set; }
        protected DateTime OnboardDate { get; set; }

        public Employee()
        {

        }

        public Employee(string employeeCode, string name, int baseSalary, double levelNumber, DateTime onboardDate)
        {
            this.EmployeeCode = employeeCode;
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.LevelNumber = levelNumber;
            this.OnboardDate = onboardDate;
        }
        public string getName()
        {
            return this.Name;
        }

        public string getEmployeeCode()
        {
            return this.EmployeeCode;
        }

        public abstract void Position();

        public double Salary()
        {
            DateTime today = DateTime.Today;
            int NgayHomNay = today.Year * 10000 + today.Month * 100 + today.Day;
            int NgayOnboard = this.OnboardDate.Year * 10000 + this.OnboardDate.Month * 100 + this.OnboardDate.Day;
            int result = NgayHomNay - NgayOnboard + 1;
            return this.BaseSalary * this.LevelNumber * result;
        }


        public string generateID()
        {

            string number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);

            return number;
        }


        public void NhapThongTin()
        {
            this.EmployeeCode = generateID();

            while (true)
            {
                try
                {
                    Console.Write("Please enter name: ");
                    this.Name = Console.ReadLine();
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid data Please re-enter");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Please enter BaseSalary: ");
                    this.BaseSalary = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid data Please re-enter");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Please enter LevelNumber: ");
                    this.LevelNumber = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid data Please re-enter");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Please enter OnboardDate format yyyy-MM-dd: ");
                    this.OnboardDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid data Please re-enter");
                }
            }

        }

        public void XuatThongTin()
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            Console.WriteLine("Name : {0}", this.Name);
            Console.WriteLine("Salary : {0}", String.Format(info, "{0:c}", this.Salary()));
        }
    }
}
