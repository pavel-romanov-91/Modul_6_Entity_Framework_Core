using FirstEF6App;
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
                User user3 = new User { Name = "Tor", Age = 27 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                var users = db.Users;
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    //Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                }
            }
            //using (UserContext db = new UserContext())
            //{
            //    var users = (from user in db.Users
            //                 where user.Company.Name == "Google"
            //                 select user).ToList();
            //    foreach (User user in users)
            //        Console.WriteLine($"{user.Name} ({user.Age})");
            //}    
            Console.Read();
        }
    }
}
