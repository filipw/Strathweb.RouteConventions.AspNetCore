using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class ItemController : Controller
    {
        // overall route: /api/v{version}/item/{id}
        [Route("item/{id}")]
        public string GetById(int id, int version)
        {
            //do stuff with version and id
            return $"item: {id}, version: {version}";
        }
    }
}
