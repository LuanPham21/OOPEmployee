using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPEmployee
{
    internal class Team : Company
    {
        public Team() { }
        public void XuatThongTin()
        {
            foreach (List<Employee> subList in data)
            {
                foreach (Employee item in subList)
                {
                    //string flag = item.GetType().Name;
                    //if (flag == "Manager")
                    //{
                    //    Console.WriteLine("Team Leader : {0}", item.getName());
                    //}
                    item.XuatThongTin();
                }
                Console.WriteLine();
            }
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
                        Console.Write("Team Leader Name : {0} , EmployeeCode : {1}", item.getName(), item.getEmployeeCode());
                    }
                }
                Console.WriteLine();
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
                    foreach (Employee item in subList)
                    {
                        string flag = item.GetType().Name;
                        if (flag == "Manager")
                        {
                            employee = item.getName();
                        }
                    }
                    count = dem;
                }
            }
            Console.WriteLine("The name of manager who have most crowded member in the company : {0} ", employee);

        }
        public void MemberTeam()
        {
            string employee = "";
            foreach (List<Employee> subList in data)
            {
                int manager = 0, designer = 0, developer = 0, tester = 0;
                foreach (Employee item in subList)
                {
                    string flag = item.GetType().Name;
                    if (flag == "Manager")
                    {
                        manager++;
                        employee = item.getName();
                    }
                    if (flag == "Developer")
                    {
                        developer++;
                    }
                    if (flag == "Designer")
                    {
                        designer++;
                    }
                    if (flag == "Tester")
                    {
                        tester++;
                    }
                }
                if (manager == 0 || designer == 0 || developer == 0 || tester == 0)
                {
                    Console.WriteLine("The name of manager in team not enough 4 positions : {0} ", employee);
                }
            }
        }

    }
}
