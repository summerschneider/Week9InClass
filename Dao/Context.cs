using Class_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9.Dao
{
    public class Context
    {
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }

        public Context()
        {
            Dogs = new List<Dog>
            {
                new Dog {Name="Rover", DogOwner="Roger"},
                new Dog {Name="Spot", DogOwner="Scott"},
                new Dog {Name="Fido", DogOwner="Fred"}
            };
            Cats = new List<Cat>
            {
                new Cat {Name="Fluffy", CatOwner="Fifi"},
                new Cat {Name="Garfield", CatOwner="Jon"},
                new Cat {Name="Felix", CatOwner="Frank"}
            };
        }
    }
}
