using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Resources;
using System.Threading;
using System.Web.Http;

namespace Angulari18n.Controllers
{
    public class TranslationController : ApiController
    {


        [HttpGet]
        [Route("api/translation/get")]
        public HttpResponseMessage Get(String lang)
        {
            var resourcesDictionary = App_LocalResources.Site.ResourceManager
                .GetResourceSet(CultureInfo.CreateSpecificCulture(lang), true, true)
                .Cast<DictionaryEntry>()
                .ToDictionary(
                    r => r.Key.ToString(),
                    r => r.Value.ToString()
                 );

            return Request.CreateResponse(HttpStatusCode.OK, resourcesDictionary);
        }
    }
}
