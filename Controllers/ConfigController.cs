//#https://docs.microsoft.com/zh-tw/aspnet/core/fundamentals/configuration/options?view=aspnetcore-2.1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Sun.Configuration;
using Sun.Helper;

namespace Sun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly MyOptions _myOptions;
        private readonly MySubOptions _mySubOptions;
        private readonly DBHelper _dbHelper;
        public ConfigController(IConfiguration config, IOptions<MyOptions> myOption, IOptions<MySubOptions> mySubOption, DBHelper dbHelper)
        {
            this._config = config;
            this._myOptions = myOption.Value;
            this._mySubOptions = mySubOption.Value;
            this._dbHelper = dbHelper;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok(this._config["configA"]);
        }

        [HttpGet("MyOptions")]
        public ActionResult<MyOptions> GetMyOption()
        {
            return Ok(this._myOptions);
        }

        [HttpGet("MySubOptions")]
        public ActionResult<MySubOptions> GetMyOption2()
        {
            return Ok(this._mySubOptions);
        }
        [HttpGet("ConnStr")]
        public ActionResult<MySubOptions> GetConnectionString()
        {
            return Ok(this._dbHelper.GetConnStr());
        }
    }
}
