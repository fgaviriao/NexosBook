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
    public class BookConfigurationServices : IBookConfigurationServices
    {
        private readonly IBookConfigurationRepository _repository;
        private readonly IMapper _mapper;
        public BookConfigurationServices(IBookConfigurationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public BookConfigurationDto GetConfiguration()
        {
            var row = _repository.GetConfiguration();
            return _mapper.Map<BookConfigurationDto>(row);
        }
        public BookConfigurationDto Create(BookConfigurationDto data)
        {
            var dbmodel = _repository.GetConfiguration();
            if (dbmodel != null)
            {
                _mapper.Map(data, dbmodel);

                _repository.Update(dbmodel);
                _repository.SaveChanges();

                return data;
            }

            return null;
        }
    }
}
