using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_VideoJuegos.Models;

namespace API_VideoJuegos.Controllers
{
    public class apiJuegosController : ApiController
    {
        Model_DB db = new Model_DB();

        public IEnumerable<juego> Get()
        {
            return db.juegos;
        }

    }
}
