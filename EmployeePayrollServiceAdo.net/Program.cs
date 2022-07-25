// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace EmployeePayRollServiceAdo.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Welcome TO Employee PayRoll Services Using ADO.NET----------");
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.GetDataFromSql();

        }
    }
}