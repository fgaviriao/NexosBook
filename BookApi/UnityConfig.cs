using AutoMapper;
using Book.Data.Repositories;
using Book.Services;
using Book.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace BookApi
{
    public static class DependencyInjection
    {
        public static void RegisterDependencyInjection()
        {
            var container = new UnityContainer();
            
            container.RegisterType<IAuthorRepository, AuthorRepository>();
            container.RegisterType<IBookRepository, BookRepository>();

            container.RegisterType<IBookServices, BookServices>();
            container.RegisterType<IAuthorServices, AuthorServices>();


            var automapperConfiguration = new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new AuthorAutoMapperProfile());
                configuration.AddProfile(new BookAutoMapperProfile());
            });

            container.RegisterInstance<IMapper>(automapperConfiguration.CreateMapper());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);


        }
    }
}