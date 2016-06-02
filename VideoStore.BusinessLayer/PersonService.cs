namespace BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VideoStore.Repository;
    using VideoStore.Model;

    public class PersonService
    {
        private PersonRepository personRepository = new PersonRepository();
        private OrderRepository orderRepository = new OrderRepository();

        public string AddPerson(string personName, string bornYear)
        {
            if (personName != "" & bornYear != "")
            {
                try
                {
                    int year = int.Parse(bornYear);
                    var personEntity = new PersonEntity()
                    {
                        Name = personName,
                        BornYear = year

                    };

                    if (personRepository.HasEntity(personName) == false)
                    {
                        personRepository.AddEntity(personEntity);
                        return "Клиентът е запазен";
                    }
                    else { return "Имате дублиращ се запис!"; }
                }
                catch (OutOfMemoryException)
                {
                    return "Достигнахте лимита на паметта за съхранение!";
                }
                catch(IndexOutOfRangeException)
                {
                    return "Въвели сте стойност по-голяма от допустимата";
                }
                catch(Exception ex)
                {
                    return ex.ToString();
                }
            }
            else
            {
                return "Имате непопълнини полета!";
            }

        }

        public string UpdatePerson(string personId, string personName, string bornYear)
        {
            if (personId != "" & personName != "" & bornYear != "")
            {
                int id = int.Parse(personId);
                int year = int.Parse(bornYear);
                var personEntity = new PersonEntity()
                {
                    Id = id,
                    Name = personName,
                    BornYear = year

                };

                if (personRepository.HasEntityByNameAndOtherId(personEntity) == false)
                {
                    personRepository.UpdateEntity(personEntity);
                    return "Клиентът е запазен";
                }
                else { return "Имате дублиращ се запис!"; }
            }

            else { return "Имате непопълнини полета!"; }            
        }

        public string DeletePerson(string personName)
        {
            if(personRepository.HasEntity(personName) == true)
            {
                if (orderRepository.PersonHasOrders(personName) == false)
                {
                    personRepository.DeleteEntity(personName);
                    return "Клиента е изтрит.";
                }
                else { return "Клиента не е изтрит. Възможно е да има направени поръчки."; }
            }
            else { return "Въвели сте несъществуващ клиент."; }
        }

        public List<string> SelectPerson(string personName)
        {
            return personRepository.SelectByName(personName);
        }

    }
}
