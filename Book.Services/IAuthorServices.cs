using Book.Services.Dto;
using System.Collections.Generic;

namespace Book.Services
{
    public interface IAuthorServices
    {
        AuthorDto Create(AuthorDto data);
        bool Delete(int id);
        IEnumerable<AuthorDto> GetAll();
        AuthorDto GetById(int id);
        AuthorDto Update(int id, AuthorDto data);
    }
}