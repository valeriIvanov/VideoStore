namespace BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoClub.Repository;
    using VideoClub.Models;

    public class PersonService
    {
        PersonRepository personRepository = new PersonRepository();

        public string AddPerson(string personName, string bornYear)
        {
            if (personName != null & bornYear != "")
            {
                int year = int.Parse(bornYear);
                var personEntity = new PersonEntity()
                {
                    Name = personName,
                    BornYear = year

                };

                if(personRepository.HasPerson(personName) == false)
                {
                    personRepository.AddPerson(personEntity);
                    return "Клиентът е запазен";
                }
                else { return "Имате дублиращ се запис!"; }
            }

            else
            {
                return "Имате непопълнини полета!";
            }

        }

        public string DeletePerson(string personName)
        {
            if(personRepository.HasPerson(personName) == true)
            {
                if (personRepository.DeletePerson(personName) == true)
                {
                    return "Клиента е изтрит.";
                }
                else { return "Клиента не е изтрит. Възможно е да има направени поръчки."; }
            }
            else { return "Въвели сте несъществуващ клиент."; }
        }

        public List<string> SelectPerson(string personName)
        {
            return personRepository.SelectPerson(personName);
        }

    }
}
