namespace VideoClub.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoClub.Models;
    using VideoClub.Data;

    public class PersonRepository
    {
        public List<string> SelectPerson(string personName)
        {
            List<string> personList = new List<string>();
            using(var db = new VideoClubDbContext())
            {
                var person = db.Persons
                    .Where(p => p.Name == personName)
                    .FirstOrDefault();
                personList.Add(person.Id.ToString());
                personList.Add(person.Name.ToString());
                personList.Add(person.BornYear.ToString());
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

        public bool DeletePerson(string personName)
        {
            using(var db = new VideoClubDbContext())
            {
                var person = db.Persons
                    .Where(p => p.Name == personName)
                    .First();
                db.Persons.Remove(person);
                if(person.Id !=0)
                {
                    return true;
                }
                else { return false; }
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
