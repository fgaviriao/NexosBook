﻿using AutoMapper;
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
    public class BookServices : IBookServices
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookServices(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<BookDto> GetAll()
        {
            var rows = _repository.GetAll();
            return _mapper.Map<IEnumerable<BookDto>>(rows);
        }

        public BookDto GetById(int id)
        {
            var rows = _repository.GetById(id);
            return _mapper.Map<BookDto>(rows);
        }

        public BookDto Create(BookDto data)
        {
            var dbmodel = _mapper.Map<Data.Book>(data);
            _repository.Save(dbmodel);
            _repository.SaveChanges();
            var dto = _mapper.Map<BookDto>(dbmodel);
            return dto;
        }

        public BookDto Update(int id, BookDto data)
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

        public IEnumerable<BookDto> GetAllByAuthorId(int id)
        {
            var rows = _repository.GetAllByAuthorId(id);
            return _mapper.Map<IEnumerable<BookDto>>(rows);
        }
    }
}
