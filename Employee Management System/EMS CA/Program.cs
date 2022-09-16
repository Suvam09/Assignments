using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitwareLib;

namespace EMS_CA
{

    public class EmployeeManagement
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Employee Management System for LITWARE ORGANIZATION");
                Employee employee = new Employee();
                Display(employee);
                CalculateSalary(employee);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please provide a valid entry");
            }
        }

        static void Display(Employee employee)
        {
            Console.WriteLine("Enter Your Employee Number :");
            employee.EmpNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Name :");
            employee.EmpName = Console.ReadLine();

            Console.WriteLine("Enter Your Salary");
            employee.Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("=====Your Details===== ");
            Console.WriteLine("Employee No : " + employee.EmpNo);
            Console.WriteLine("Name : " + employee.EmpName);
            Console.WriteLine("Salary : " + employee.Salary);

            if (employee.Salary >= 20000)
            {
                employee.HRA = (employee.Salary * 30) / 100;
                employee.TA = (employee.Salary * 25) / 100;
                employee.DA = (employee.Salary * 35) / 100;
            }
            else if (employee.Salary < 20000 && employee.Salary > 15000)
            {
                employee.HRA = (employee.Salary * 25) / 100;
                employee.TA = (employee.Salary * 20) / 100;
                employee.DA = (employee.Salary * 30) / 100;
            }
            else if (employee.Salary < 15000 && employee.Salary > 10000)
            {
                employee.HRA = (employee.Salary * 20) / 100;
                employee.TA = (employee.Salary * 15) / 100;
                employee.DA = (employee.Salary * 25) / 100;
            }
            else if (employee.Salary < 10000 && employee.Salary > 5000)
            {
                employee.HRA = (employee.Salary * 15) / 100;
                employee.TA = (employee.Salary * 10) / 100;
                employee.DA = (employee.Salary * 20) / 100;
            }
            else
            {
                employee.HRA = (employee.Salary * 10) / 100;
                employee.TA = (employee.Salary * 5) / 100;
                employee.DA = (employee.Salary * 15) / 100;

            }
            employee.GrossSalary = employee.Salary + employee.HRA + employee.TA + employee.DA;
            Console.WriteLine("=====================");
            Console.WriteLine("YOUR Gross Salary = " + employee.GrossSalary);


        }


        static void CalculateSalary(Employee employee)
        {


            employee.PF = (employee.GrossSalary * 10) / 100;
            employee.TDS = (employee.GrossSalary * 18) / 100;
            employee.NetSalary = employee.GrossSalary - (employee.PF + employee.TDS);
            Console.WriteLine("Your Net Salary = " + employee.NetSalary);

            Console.WriteLine("======================");

        }

    }

}
