using Book.Services.Dto;
using System.Collections.Generic;

namespace Book.Services
{
    public interface IBookServices
    {
        BookDto Create(BookDto data);
        bool Delete(int id);
        IEnumerable<BookDto> GetAll();
        IEnumerable<BookDto> GetAllByAuthorId(int id);
        BookDto GetById(int id);
        BookDto Update(int id, BookDto data);
    }
}