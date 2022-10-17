using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public Employee() { }

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

        public double setBaseSalary()
        {
            return this.BaseSalary = 500000;
        }

        public double Salary()
        {
            setBaseSalary();
            DateTime today = DateTime.Today;
            TimeSpan interval = today - this.OnboardDate;
            int result = interval.Days;
            return this.BaseSalary * this.LevelNumber * result;
        }

        public string generateID()
        {
            string number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            return number;
        }

        public static bool CheckName(string filename)
        {
            string azpattern = "[a-z]+";
            return Regex.IsMatch(filename, azpattern);
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
                    if(CheckName(this.Name)) break;
                    else Console.WriteLine("Invalid data Please re-enter");
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
                    if (this.OnboardDate < DateTime.Now.Date) break;
                    else Console.WriteLine("OnboardDate is now limited to date.");
                }
                catch
                {
                    Console.WriteLine("Invalid data Please re-enter");
                }
            }
        }

        public Tuple<string, string, string> XuatThongTin()
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string salary = String.Format(info, "{0:c}", this.Salary());
            return new Tuple<string, string, string>(this.EmployeeCode, this.Name, salary);
        }

        public Tuple<string,string, string> ShowAllEmployeee()
        {
            return new Tuple<string,string, string>(this.EmployeeCode,this.Name,this.OnboardDate.ToString("yyyy/MM/dd"));
        }
    }
}
