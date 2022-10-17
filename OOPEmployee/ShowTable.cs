using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEmployee
{
    public class ShowTable
    {
        public static void Table()
        {

            int so = 0;
            Employee employee;
            Team team = new Team();
            do
            {
                while (true)
                {
                    try
                    {
                        PrintLine.PrintColumn();
                        PrintLine.PrintTilte("Please choose number : ");
                        PrintLine.PrintTilte("1). Add new employee ");
                        PrintLine.PrintTilte("2). Remove employee");
                        PrintLine.PrintTilte("3). Show the total salary of all employee ");
                        PrintLine.PrintTilte("4). Show the name of manager who have most crowded member in the company");
                        PrintLine.PrintTilte("5). Show the name of manager in team not enough 4 positions");
                        PrintLine.PrintTilte("6). Show all employee");
                        PrintLine.PrintTilte("7). Total amount of employees");
                        PrintLine.PrintColumn();
                        Console.Write("Input your number: ");
                        so = Int32.Parse(Console.ReadLine());

                        switch (so)
                        {
                            case 1:
                                while (true)
                                {
                                    try
                                    {
                                        PrintLine.PrintColumn();
                                        PrintLine.PrintTilte("Please choose number");
                                        PrintLine.PrintTilte("1). Add Manager ");
                                        PrintLine.PrintTilte("2). Add Designer ");
                                        PrintLine.PrintTilte("3). Add Developer ");
                                        PrintLine.PrintTilte("4). Add Tester ");
                                        PrintLine.PrintColumn();
                                        Console.Write("Input your number: ");
                                        int choose = Int32.Parse(Console.ReadLine());
                                        switch (choose)
                                        {
                                            case 1:
                                                employee = new Manager();
                                                employee.NhapThongTin();
                                                employee.Position();
                                                team.CreateTeam(employee);
                                                break;
                                            case 2:
                                                employee = new Designer();
                                                employee.NhapThongTin();
                                                employee.Position();
                                                team.ShowLeader();
                                                Console.WriteLine("Please choose Team Leader ");
                                                Console.Write("Input Employcode : ");
                                                string nameLeader = Console.ReadLine();
                                                team.AddTeam(employee, nameLeader);
                                                break;
                                            case 3:
                                                employee = new Developer();
                                                employee.NhapThongTin();
                                                employee.Position();
                                                team.ShowLeader();
                                                Console.WriteLine("Please choose Team Leader ");
                                                Console.Write("Input Employcode : ");
                                                nameLeader = Console.ReadLine();
                                                team.AddTeam(employee, nameLeader);
                                                break;
                                            case 4:
                                                employee = new Tester();
                                                employee.NhapThongTin();
                                                employee.Position();
                                                team.ShowLeader();
                                                Console.WriteLine("Please choose Team Leader ");
                                                Console.Write("Input Employcode : ");
                                                nameLeader = Console.ReadLine();
                                                team.AddTeam(employee, nameLeader);
                                                break;
                                        }
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Invalid data Please re-enter");
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Please input EmployCode need delete");
                                string name = Console.ReadLine();
                                team.RemoveTeam(name);
                                break;
                            case 3:
                                team.XuatThongTin();
                                break;
                            case 4:
                                team.CountTeam();
                                break;
                            case 5:
                                team.MemberTeam();
                                break;
                            case 6:
                                team.ShowAllEmployeee();
                                break;
                            case 7:
                                team.TotalEmployees();
                                break;
                            default:
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid data Please re-enter");
                    }
                }
            } while (so != 0);
        }
    }
}
