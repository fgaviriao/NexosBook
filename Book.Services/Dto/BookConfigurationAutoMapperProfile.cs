using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Services.Dto
{
    public class BookConfigurationAutoMapperProfile : Profile
    {
        public BookConfigurationAutoMapperProfile()
        {
            CreateMap<Data.BookConfiguration, BookConfigurationDto>();
            CreateMap<BookConfigurationDto, Data.BookConfiguration>();

        }
    }
}
