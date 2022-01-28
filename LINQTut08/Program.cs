using LINQTut08.Shared;
using System;
using System.Linq;

namespace LINQTut08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunGroupByExample();
            RunLookupExample();
            RunGroupByWithQuerySyntax();
            Console.ReadKey();
        }

        private static void RunGroupByExample()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("GroupBy (Method Syntax");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();
            var result = employees.GroupBy(x => x.Department);
            foreach (var item in result)
            {
                item.Print($"Employee in '{item.Key}' Department");
            }
        }

        private static void RunLookupExample()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("ToLookup (Method Syntax");
            Console.WriteLine("+++++++++++++++++++++++"); 
            Console.WriteLine();

            var employees = Repository.LoadEmployees(); 
            var result = employees.ToLookup(x => x.Department);
            foreach (var item in result) 
            {
                item.Print($"Employee in '{item.Key}' Department");
            }
        }

        private static void RunGroupByWithQuerySyntax()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("GroupBy (Query Syntax");
            Console.WriteLine("+++++++++++++++++++++++"); 
            Console.WriteLine();

            var employees = Repository.LoadEmployees();
            var result = from emp in employees
                         group emp by emp.Department;
            
            foreach (var item in result)
            {
                item.Print($"Employee in '{item.Key}' Department");
            }
        }
    }
}
