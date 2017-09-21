using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TentaWeb2.Models;

namespace TentaWeb2.Data
{
    public static class Seed
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if(!context.Students.Any())
            {
                var student = new Student()
                {
                    Name = "Carl-Fredrik",
                    Mail = "electrodez@gmail.com",
                    Phone = "0700391100",
                    GitHubHomeUrl = "https://github.com/Call3z",
                    GoogleAccount = "electrodez@gmail.com"

                };

                context.Students.Add(student);
                context.SaveChanges();

            }
        }
    }
}
