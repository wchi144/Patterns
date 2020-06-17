using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPattern_DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IFactory _factory;

        public ValuesController(IFactory factory)
        {
            _factory = factory;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Console.WriteLine("Hello World!");
            var recordProcessor = _factory.GetRecord(RecodeType.BankConnection);

            return $"It's time for {recordProcessor.GetRecord()}'";
        }
    }
}
