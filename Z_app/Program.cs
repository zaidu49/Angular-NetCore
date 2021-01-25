using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Z_app.Models;

namespace Z_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            //using (var db = new AppDataContext())
            //{
            //    //Seed data
            //    db.Employees.AddRange(new Employee {  Name = "z1", City = "Bourenmouth", Department = "IT", Gender = "Male" },
            //                          new Employee {  Name = "z2", City = "Bourenmouth1", Department = "IT", Gender = "Male" }
                
            //);
            //    db.Cities.AddRange(new City { CityName = "Bournemouth" },
            //                       new City { CityName = "London" }
            //                       );
            //    db.SaveChanges();
            //}
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
