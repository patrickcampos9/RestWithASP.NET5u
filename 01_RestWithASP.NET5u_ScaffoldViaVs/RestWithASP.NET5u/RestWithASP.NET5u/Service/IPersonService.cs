using RestWithASP.NET5u.Model;
using System.Collections.Generic;


namespace RestWithASP.NET5u.Service
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
