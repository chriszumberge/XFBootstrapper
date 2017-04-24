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
    public class AdvancedController : ApiController
    {
        /// <summary>
        /// Gets all the available advanced settings.
        /// </summary>
        /// <returns>A list of AdvancedSettingViewModel objects.</returns>
        /// <seealso cref="XFBootstrapper.OpenWebAPI.ViewModels.AdvancedSettingViewModel"/>
        [Route("api/AdvancedSettings")]
        [HttpGet]
        [ResponseType(typeof(List<AdvancedSettingViewModel>))]
        [EnableCors(origins: "http://xfbootstrapper.azurewebsites.net", headers: "*", methods: "*")]
        public IHttpActionResult Get()
        {
            return Ok(AdvancedSetting.GetAll().Select(x => new AdvancedSettingViewModel(x)).ToList());
        }
    }
}
