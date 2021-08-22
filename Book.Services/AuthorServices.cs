using AutoMapper;
using Book.Data;
using Book.Data.Repositories;
using Book.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Services
{
    public class AuthorServices : IAuthorServices
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public AuthorServices(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<AuthorDto> GetAll()
        {
            var rows = _repository.GetAll();
            return _mapper.Map<IEnumerable<AuthorDto>>(rows);
        }

        public AuthorDto GetById(int id)
        {
            var rows = _repository.GetById(id);
            return _mapper.Map<AuthorDto>(rows);
        }

        public AuthorDto Create(AuthorDto data)
        {
            var dbmodel = _mapper.Map<Author>(data);
            _repository.Save(dbmodel);
            _repository.SaveChanges();
            var dto = _mapper.Map<AuthorDto>(dbmodel);
            return dto;
        }

        public AuthorDto Update(int id, AuthorDto data)
        {
            var dbmodel = _repository.GetById(id);
            if (dbmodel != null)
            {
                _mapper.Map(data, dbmodel);

                _repository.Update(dbmodel);
                _repository.SaveChanges();

                return data;
            }

            return null;
        }

        public bool Delete(int id)
        {
            var dbmodel = _repository.GetById(id);
            if (dbmodel != null)
            {
                _repository.Delete(dbmodel);
                _repository.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
