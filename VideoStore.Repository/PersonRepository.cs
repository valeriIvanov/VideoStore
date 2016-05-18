namespace VideoStore.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoStore.Models;

    public class PersonRepository
    {
        public List<string> SelectPerson(string personName)
        {
            List<string> personList = new List<string>();
            using(var db = new VideoClubDbContext())
            {
                var person = db.Persons
                    .Where(p => p.Name == personName)
                    .ToList();
                foreach (var subject in person)
                {
                    personList.Add(subject.Id.ToString());
                    personList.Add(subject.Name.ToString());
                    personList.Add(subject.BornYear.ToString());
                }
                return personList;
            }
        }

        public bool AddPerson(PersonEntity Person)
        {
            using(var db = new VideoClubDbContext())
            {
                db.Persons.Add(Person);
                db.SaveChanges();
            }
            return true;
        }

        public bool UpdatePerson(PersonEntity person)
        {
            using(var db = new VideoClubDbContext())
            {
                var updatedPerson = db.Persons
                    .Where(p => p.Id == person.Id)
                    .First();
                updatedPerson.Name = person.Name;
                updatedPerson.BornYear = person.BornYear;
                db.SaveChanges();
            }
            return true;
        }

        public bool DeletePerson(string personName)
        {
            using(var db = new VideoClubDbContext())
            {
                var person = db.Persons
                    .Where(p => p.Name == personName)
                    .First();
                db.Persons.Remove(person);
                db.SaveChanges();
                return true;
            }
        }

        public bool HasPerson(string name)
        {
            using(var db = new VideoClubDbContext())
            {
               
                var hasName = db.Persons
                    .Where(h => h.Name == name)
                    .Any();
                return hasName;
            }
        }

        public bool HasAnotherPersonByNameAndId(PersonEntity person)
        {
            using (var db = new VideoClubDbContext())
            {

                var hasPerson = db.Persons
                    .Where(h => h.Name == person.Name & h.Id != person.Id)
                    .Any();
                return hasPerson;
            }
        }

        public int PersonId(string name)
        {
            using (var db = new VideoClubDbContext())
            {

                var hasName = db.Persons
                    .Where(h => h.Name == name)
                    .FirstOrDefault();
                return hasName.Id;
            }
        }

        public PersonEntity GetPersonEntity(string personName)
        {
            using(var db = new VideoClubDbContext())
            {
                var person = db.Persons
                    .Where(p => p.Name == personName)
                    .FirstOrDefault();
                return person;
            }
        }

    }
}
