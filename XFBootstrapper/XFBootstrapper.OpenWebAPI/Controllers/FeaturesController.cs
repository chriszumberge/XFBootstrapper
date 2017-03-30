using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using XFBootstrapper.Extensibility;
using XFBootstrapper.OpenWebAPI.ViewModels;

namespace XFBootstrapper.OpenWebAPI.Controllers
{
    public class FeaturesController : ApiController
    {
        [Route("api/Features")]
        [HttpGet]        
        [ResponseType(typeof(List<FeatureViewModel>))]
        [EnableCors(origins: "http://xfbootstrapper.azurewebsites.net", headers: "*", methods: "*")]
        public IHttpActionResult Get()
        {
            return Ok(ExtensionPoint.GetAll().Select(x => new FeatureViewModel(x)).ToList());
        }
    }
}
