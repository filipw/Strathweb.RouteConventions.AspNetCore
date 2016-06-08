using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    // gets merged into the global route prefix
    [Route("other")]
    public class OtherController : Controller
    {
        // overall route: /api/v{version}/other/resource/{id}
        [Route("resource/{id}")]
        public string GetById(int id, int version)
        {
            //do stuff with version and id
            return $"other resource: {id}, version: {version}";
        }
    }
}
