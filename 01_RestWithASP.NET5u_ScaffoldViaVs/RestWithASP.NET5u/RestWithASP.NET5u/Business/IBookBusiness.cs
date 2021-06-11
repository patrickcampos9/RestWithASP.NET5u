using RestWithASP.NET5u.Model;
using System.Collections.Generic;


namespace RestWithASP.NET5u.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book person);
        void Delete(long id);
    }
}
