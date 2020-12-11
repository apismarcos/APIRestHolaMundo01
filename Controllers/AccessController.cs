using Ejemplo01.Models.WS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ejemplo01.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        public Reply HolaMundo()
        {
            Reply oR = new Reply();
            oR.result = 1;
            oR.message = "Hola Mundo";

            return oR;

        }
    }
}
