using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DogBlogMvc.Models
{
    public class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public string Breed { get; set; }

        public string Description { get; set; }
    }
}
