using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEmployee
{
    internal class Company
    {
        protected List<List<Employee>> data = new List<List<Employee>>();

        public Company()
        {
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.AddRange(new Employee[] {
            new Manager("779054773", "Pham Van A",700000, 2.5,new DateTime(2022, 9, 1)),
            new Developer("779054931" ,"Nguyen Van C", 500000,1.8, new DateTime(2022, 9, 1, 0, 0, 0)),
            new Developer("779054970" ,"Pham Thi D", 500000,1.7, new DateTime(2022, 9, 2, 0, 0, 0)),
            new Designer("779055008" ,"Lai Van E", 500000,1.5, new DateTime(2022, 9, 2, 0, 0, 0) ),
            new Designer("779055045" ,"Dao Van F", 500000,1.5,  new DateTime(2022, 9, 2, 0, 0, 0)),
             }); ;

            List<Employee> listEmployee2 = new List<Employee>();
            listEmployee2.AddRange(new Employee[] {
            new Manager("950400589", "Nguyen Ba A",700000, 2.4,new DateTime(2022, 9, 1)),
            new Tester("976131603" ,"Pham Thi C", 500000,1.8, new DateTime(2022, 9, 1, 0, 0, 0)),
            new Developer("976133726" ,"Nguyen Luu D", 500000,1.7, new DateTime(2022, 9, 2, 0, 0, 0)),
            new Developer("976133774" ,"Dao Tu B", 600000,1.8, new DateTime(2022, 9, 2, 0, 0, 0) ),
            new Designer("976133811" ,"Luu Duc E", 500000,1.5,  new DateTime(2022, 9, 2, 0, 0, 0)),
             }); ;

            data.AddRange(new List<Employee>[] { listEmployee, listEmployee2 });
        }
    }
}
