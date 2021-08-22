using Book.Services;
using Book.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BookApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AuthorsController : ApiController
    {
        private readonly IAuthorServices _service;
        public AuthorsController(IAuthorServices service)
        {
            _service = service;
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _service.GetAll(), Configuration.Formatters.JsonFormatter);
        }

        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _service.GetById(id), Configuration.Formatters.JsonFormatter);
        }

        [HttpPost]
        public HttpResponseMessage Post(AuthorDto data)
        {
            try
            {
               var row = _service.Create(data);
               return Request.CreateResponse(HttpStatusCode.OK, row, Configuration.Formatters.JsonFormatter);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put(int id, AuthorDto data)
        {
            try
            {
                var row = _service.Update(id,data);
                if(row != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, row, Configuration.Formatters.JsonFormatter);
                }
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                if (_service.Delete(id))
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
