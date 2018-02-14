using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserSearch.Models;

namespace UserSearch.Data
{
    public class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            Console.WriteLine("Initializing Database...");
            Console.Read();
            context.Database.EnsureCreated();
            Console.WriteLine("Database Initialized.");
            Console.WriteLine("Seeding...");
            // look for any users.
            if(context.Users.Any())
            {
                return; //DB has been seeded
            }
            Console.WriteLine("Seeded.");
            Console.Read();
            var users = new User[]
            {
                new User{FirstName="John",LastName="Jacob",Address="300 west 300 south",Age=15,PhoneNumber="801-555-5555"},
                new User{FirstName="Mario",LastName="Speedwagon",Address="300 west 300 south",Age=29,PhoneNumber="801-555-5555"},
                new User{FirstName="Petey",LastName="Cruiser",Address="300 west 300 south",Age=52,PhoneNumber="801-555-5555"},
                new User{FirstName="Anna",LastName="Sthesia",Address="300 west 300 south",Age=40,PhoneNumber="801-555-5555"},
                new User{FirstName="Paul",LastName="Molive",Address="300 west 300 south",Age=16,PhoneNumber="801-555-5555"},
                new User{FirstName="Anna",LastName="Mull",Address="300 west 300 south",Age=15,PhoneNumber="801-555-5555"},
                new User{FirstName="Gail",LastName="Forcewind",Address="300 west 300 south",Age=32,PhoneNumber="801-555-5555"},
                new User{FirstName="Brock",LastName="Lee",Address="300 west 300 south",Age=51,PhoneNumber="801-555-5555"},
                new User{FirstName="Shonda",LastName="Leer",Address="300 west 300 south",Age=10,PhoneNumber="801-555-5555"},
                new User{FirstName="Cliff",LastName="Hanger",Address="300 west 300 south",Age=11,PhoneNumber="801-555-5555"},
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}
