using AutoMapper;
using Book.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Services.Dto
{
    public class AuthorAutoMapperProfile: Profile
    {
        public AuthorAutoMapperProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<AuthorDto, Author>();
        }
    }
}
