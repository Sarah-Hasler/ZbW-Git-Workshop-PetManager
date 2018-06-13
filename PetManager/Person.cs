using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PetManager {
    public class Person {
        public Person() {
            this.Pets = new BindingList<Pet>();
        }
        public string Lastname { get; set; }
        public string Firstname { get; set; }

        public BindingList<Pet> Pets { get; private set; }


        public static BindingList<Person> GetDemoData() {
            var ret = new BindingList<Person>();
            var person = new Person() {Lastname = "Müller", Firstname = "Max"};
            person.Pets.Add(new Pet { Name = "Cäsar", Breed = "Kanarienvogel"});
            person.Pets.Add(new Pet { Name = "Bello", Breed = "Hund" });
            ret.Add(person);

            person = new Person() { Lastname = "Doe", Firstname = "John" };
            person.Pets.Add(new Pet { Name = "Fleckli", Breed = "Kaninchen" });
            person.Pets.Add(new Pet { Name = "Hoppel", Breed = "Kaninchen" });
            person.Pets.Add(new Pet { Name = "Wau", Breed = "Hund" });
            ret.Add(person);

            return ret;
        }

        public override bool Equals(object obj) {
            if (!(obj is Person)) {
                return object.Equals(obj, this);
            }

            var person = (Person) obj;
            return string.Equals(this.Lastname, person.Lastname) && string.Equals(this.Firstname, person.Firstname);
        }
    }
}
