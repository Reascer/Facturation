using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FactureDataController : ControllerBase
    {

        private readonly ILogger<FactureDataController> logger;
        private readonly IBusinessData data;

        public FactureDataController(ILogger<FactureDataController> logger, IBusinessData data)
        {
            this.logger = logger;
            this.data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            return data.Factures;
        }

        [HttpGet("{id}")]
        public Facture Get(int id)
        {
            return data.Factures.Where(facture => facture.numero == id).FirstOrDefault();
        }
    }
}
