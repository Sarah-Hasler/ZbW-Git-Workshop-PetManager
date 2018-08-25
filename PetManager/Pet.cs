using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetManager {
    public class Pet {

        public Pet(DateTime birthday) {
            this.Birthday = birthday;
        }
        public string Name { get; set; }
        public string Breed { get; set; }

        public DateTime Birthday { get; set; }

        public TimeSpan Age() {
            return DateTime.Today - this.Birthday;
        }

        public override bool Equals(object obj) {
            if (!(obj is Pet)) {
                return object.Equals(obj, this);
            }
            var pet = (Pet)obj;
            return string.Equals(this.Name, pet.Name) && Birthday.Equals(pet.Birthday) &&
                   string.Equals(this.Breed, pet.Breed);
        }
    }
}
