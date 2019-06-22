using Microsoft.AspNetCore.Mvc;

namespace DotnetExamples.Application
{
    public class NsJsonController : Controller
    {
        public readonly ILoggerAdapter<NsJsonController> _log;


        public NsJsonController(ILoggerAdapter<NsJsonController> log)
        {
            _log = log;
        }


        
    }
}