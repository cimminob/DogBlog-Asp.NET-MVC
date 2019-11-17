using DogBlogMvc.Models;
using System;
using System.Linq;

namespace DogBlogMvc.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DogBlogContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Dogs.Any())
            {
                return;   // DB has been seeded
            }

            var dogs = new Dog[]
            {
                new Dog
               {
                  Name = "Oreo",
                  Birthdate = DateTime.Parse("2017-3-23"),
                  Breed = "Shih Tzu",
                  Description = "friendly black and white, lap pet. Ready to be adopted"
               },
               new Dog
               {
                  Name = "Spike",
                  Birthdate = DateTime.Parse("2015-5-19"),
                  Breed = "Doberman Pincher",
                  Description = "recently retired from police duty. Good protector of the home"
               },
               new Dog
               {
                  Name = "Marshmellow",
                  Birthdate = DateTime.Parse("2019-3-12"),
                  Breed = "Standard Poodle",
                  Description = "Full of energy. Would do best in a yard"
               }, new Dog
               {
                  Name = "Spot",
                  Birthdate = DateTime.Parse("2014-4-11"),
                  Breed = "Jack Russell Terrier",
                  Description = "ADOPTED!!!!! Velcro dog, always wants to be around owner."
               }

            };
            foreach (Dog d in dogs)
            {
                context.Dogs.Add(d);
            }
            context.SaveChanges();

        }
    }
}