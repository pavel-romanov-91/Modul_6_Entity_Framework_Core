﻿using FirstEF6App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_6_Entity_Framework_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Sam", Age = 26 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                var users = db.Users;
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                }
            }
            Console.Read();
        }
    }
}
