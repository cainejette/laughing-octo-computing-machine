using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerTrack.Controllers
{
    public class TrackController : ApiController
    {
        /// <summary>
        /// Simple result to handle the default browser starting url
        /// </summary>
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Root()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "ServerTrack is active");
        }
    }
}