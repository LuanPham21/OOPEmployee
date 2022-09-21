// See https://aka.ms/new-console-template for more information
using OOPEmployee;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

internal class Program
{
    static void Main(string[] args)
    {
        int so = 0;
        Employee employee;
        Team team = new Team();
        do
        {
            Console.WriteLine();
            Console.WriteLine("Please choose number : ");
            Console.WriteLine("1). Add new employee ");
            Console.WriteLine("2). Remove employee");
            Console.WriteLine("3). Show the total salary of all employee ");
            Console.WriteLine("4). Show the name of manager who have most crowded member in the company");
            Console.WriteLine("5). Show the name of manager in team not enough 4 positions  ");
            so = Int32.Parse(Console.ReadLine());

            switch (so)
            {
                case 1:
                    Console.WriteLine("Please choose number");
                    Console.WriteLine("1). Add Manager ");
                    Console.WriteLine("2). Add Designer ");
                    Console.WriteLine("3). Add Developer ");
                    Console.WriteLine("4). Add Tester ");
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
                case 0:
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        } while (so != 0);

        Console.ReadKey();
    }

}
