using System;

namespace Linq.Model {
    public class Person {
        public Person (string name, string surname, DateTime birthDate, string birthPlace,string gender) {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;
            this.BirthPlace = birthPlace;
            this.Gender = gender;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }

        public string Gender { get;set;}
    }
}