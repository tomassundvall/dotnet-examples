using DotnetExamples.Model.NsJson;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotnetExamples.Application
{
    [Route("api/nsjson")]
    public class NsJsonController : Controller
    {
        public readonly ILoggerAdapter<NsJsonController> _log;


        public NsJsonController(ILoggerAdapter<NsJsonController> log)
        {
            _log = log;
        }


        public IActionResult Get()
        {
            var wObj = new Age(25);
            var obj = new ParentObj("Tomas", wObj);

            string serializedObj = JsonConvert.SerializeObject(obj, Formatting.Indented);
            _log.Information(serializedObj);

            return Ok();
        }
    }
}