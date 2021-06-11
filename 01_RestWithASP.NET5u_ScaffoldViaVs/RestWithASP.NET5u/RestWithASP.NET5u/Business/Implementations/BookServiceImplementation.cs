using RestWithASP.NET5u.Model;
using RestWithASP.NET5u.Model.Context;
using RestWithASP.NET5u.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP.NET5u.Business.Implementations
{
    public class BookServiceImplementation : IBookBusiness
    {
        private readonly IBookRepository _repository;

        public BookServiceImplementation(IBookRepository repository)
        {
            _repository = repository;
        }


        public Book Create(Book book)
        {
            
            return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

    }

        

}
