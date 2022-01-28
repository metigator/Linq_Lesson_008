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
            Console.ReadKey();
        }

        private static void RunGroupByExample()
        {
            var employees = Repository.LoadEmployees();
            var result = employees.GroupBy(x => x.Department);
            foreach (var item in result)
            {
                item.Print($"Employee in '{item.Key}' Department");
            }
        }

        private static void RunLookupExample()
        {
            var employees = Repository.LoadEmployees(); 
            var result = employees.ToLookup(x => x.Department);
            foreach (var item in result) 
            {
                item.Print($"Employee in '{item.Key}' Department");
            }
        }
    }
}
