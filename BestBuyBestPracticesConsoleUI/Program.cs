using System;
using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace BestBuyBestPracticesConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperDepartmentRepository(conn);

            var departments = repo.GetAllDepartments();

            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.DepartmentID} {dept.Name}");
            }

            Console.WriteLine("Type a new department name");

            var newDepartment = Console.ReadLine();

            repo.InsertDepartment(newDepartment);

            var deptments = repo.GetAllDepartments();

            foreach (var dept in deptments)
            {
                Console.WriteLine(dept.Name);
            }




        }
    }
}
