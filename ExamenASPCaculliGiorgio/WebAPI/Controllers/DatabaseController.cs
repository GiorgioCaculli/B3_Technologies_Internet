using Infrastructure.SqlServer.System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/database")]
    public class DatabaseController: ControllerBase
    {
        public readonly IHostEnvironment Environment;
        public readonly IDatabaseManager DatabaseManager;

        public DatabaseController(IHostEnvironment environment, IDatabaseManager databaseManager)
        {
            Environment = environment;
            DatabaseManager = databaseManager;
        }

        [HttpGet]
        [Route("init")]
        public IActionResult CreateTables()
        {
            if (Environment.IsProduction())
            {
                return BadRequest("Seulement en developpement");
            }
            DatabaseManager.CreateTables();
            return Ok("Tables creees correctement");
        }

        [HttpGet]
        [Route("fill")]
        public IActionResult FillTables()
        {
            if (Environment.IsProduction())
            {
                return BadRequest("Seulement en developpement");
            }
            DatabaseManager.FillTables();
            return Ok("Tables remplies correctement");
        }
    }
}
