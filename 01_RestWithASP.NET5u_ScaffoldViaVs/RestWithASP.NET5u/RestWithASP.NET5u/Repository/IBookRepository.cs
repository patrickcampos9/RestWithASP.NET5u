﻿using RestWithASP.NET5u.Model;
using System.Collections.Generic;


namespace RestWithASP.NET5u.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
        bool Exists(long id);
    }
}
