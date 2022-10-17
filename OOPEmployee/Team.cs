using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPEmployee
{
    internal class Team : Company
    {
        static int tableWidth = 100;
        public Team() { }
        public void XuatThongTin()
        {
            Console.WriteLine();
            PrintLine.PrintColumn();
            PrintLine.PrintRow("Employee Code","Name Employee", "Salary");
            PrintLine.PrintColumn();
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Count; j++)
                {
                    Employee employee = data[i][j];
                    var tuple = employee.XuatThongTin();
                    PrintLine.PrintRow(tuple.Item1,tuple.Item2,tuple.Item3);
                    PrintLine.PrintColumn();
                }
            }
        }

        public void ShowAllEmployeee()
        {
            Console.WriteLine();
            PrintLine.PrintColumn();
            PrintLine.PrintRow("Employee Code", "Name Employee", "Salary");
            PrintLine.PrintColumn();
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Count; j++)
                {
                    Employee employee = data[i][j];
                    var tuple = employee.ShowAllEmployeee();
                    PrintLine.PrintRow(tuple.Item1, tuple.Item2, tuple.Item3);
                    PrintLine.PrintColumn();
                }
            }
        }

        public void TotalEmployees()
        {
            int count = 0;
            foreach (List<Employee> subList in data)
            {
                int dem = subList.Count();
                count += dem;
            }
            PrintLine.PrintColumn();
            PrintLine.PrintRow("Total amount of employees: " + count);
            PrintLine.PrintColumn();
        }

        public void CreateTeam(Employee leader)
        {
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(leader);
            data.Add(listEmployee);
        }

        public void AddTeam(Employee employee, string Leader)
        {
            Boolean flag = false;
            foreach (List<Employee> subList in data)
            {
                foreach (Employee item in subList)
                {
                    string EmployeeCode = item.getEmployeeCode();
                    if (EmployeeCode == Leader)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    subList.Add(employee);
                    flag = false;
                }
            }
        }


        public void ShowLeader()
        {
            foreach (List<Employee> subList in data)
            {
                foreach (Employee item in subList)
                {
                    string flag = item.GetType().Name;
                    if (flag == "Manager")
                    {
                        PrintLine.PrintColumn();
                        PrintLine.PrintRow("Team Leader Name : " + item.getName() + " EmployeeCode : " + item.getEmployeeCode());
                        PrintLine.PrintColumn();
                    }
                }
            }
        }

        public void RemoveTeam(string Leader)
        {
            int team = 0;
            int itemDelete = 0;
            int teamDelete = 0;
            Boolean flag = false;

            foreach (List<Employee> subList in data)
            {
                int count = 0;
                foreach (Employee item in subList)
                {
                    string EmployeeCode = item.getEmployeeCode();
                    if (EmployeeCode == Leader)
                    {
                        teamDelete = team;
                        itemDelete = count;
                        flag = true;
                    }
                    count++;
                }
                team++;
            }
            if (flag)
            {
                data[teamDelete].RemoveAt(itemDelete);
                Console.WriteLine("Delete complete");
            }else
                Console.WriteLine("Delete failure");
        }

        public void CountTeam()
        {
            int count = 0;
            string employee = "";
            foreach (List<Employee> subList in data)
            {
                int dem = subList.Count();
                if (count < dem)
                {
                    employee = subList.Find(x => x.GetType().Name == "Manager").getName();
                    count = dem;
                }
            }
            PrintLine.PrintColumn();
            PrintLine.PrintRow("The name of manager who have most crowded member in the company : " + employee);
            PrintLine.PrintColumn();
        }
        public void MemberTeam()
        {
            foreach (List<Employee> subList in data)
            {
                string employee = subList.Find(x => x.GetType().Name == "Manager").getName(); 
                int num = subList.Select(x => x.GetType()).Distinct().Count();
                if (num <= 3)
                {
                    PrintLine.PrintColumn();
                    PrintLine.PrintRow("The name of manager in team not enough 4 positions : " + employee);
                    PrintLine.PrintColumn();
                }
            }
        }
    }
}
