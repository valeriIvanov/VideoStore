namespace VideoStore.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoStore.Model;

    public class PersonRepository : IRepository<PersonEntity>
    {
        public List<string> SelectByName(string name)
        {
            List<string> personList = new List<string>();
            using(var db = new VideoClubDbContext())
            {
                var person = db.Persons
                    .Where(p => p.Name == name)
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

        public bool AddEntity(PersonEntity entity)
        {
            using(var db = new VideoClubDbContext())
            {
                db.Persons.Add(entity);
                db.SaveChanges();
            }
            return true;
        }

        public bool UpdateEntity(PersonEntity entity)
        {
            using(var db = new VideoClubDbContext())
            {
                var updatedPerson = db.Persons
                    .Where(p => p.Id == entity.Id)
                    .First();
                updatedPerson.Name = entity.Name;
                updatedPerson.BornYear = entity.BornYear;
                db.SaveChanges();
            }
            return true;
        }

        public bool DeleteEntity(string name)
        {
            using(var db = new VideoClubDbContext())
            {
                var person = db.Persons
                    .Where(p => p.Name == name)
                    .First();
                db.Persons.Remove(person);
                db.SaveChanges();
                return true;
            }
        }

        public bool HasEntity(string name)
        {
            using(var db = new VideoClubDbContext())
            {
               
                var hasName = db.Persons
                    .Where(h => h.Name == name)
                    .Any();
                return hasName;
            }
        }

        public bool HasEntityByNameAndOtherId(PersonEntity entity)
        {
            using (var db = new VideoClubDbContext())
            {

                var hasPerson = db.Persons
                    .Where(h => h.Name == entity.Name & h.Id != entity.Id)
                    .Any();
                return hasPerson;
            }
        }

        public PersonEntity GetEntity(string name)
        {
            using(var db = new VideoClubDbContext())
            {
                var person = db.Persons
                    .Where(p => p.Name == name)
                    .FirstOrDefault();
                return person;
            }
        }

        public List<string> SelectAll()
        {
            List<string> personList = new List<string>();

            using(var db = new VideoClubDbContext())
            {
                var persons = db.Persons
                    .OrderBy(p => p.Name)
                    .ToList();
                foreach (var person in persons)
                {
                    personList.Add(person.Id.ToString());
                    personList.Add(person.Name.ToString());
                    personList.Add(person.BornYear.ToString());
                }
            }

            return personList;
        }
    }
}
