using Microsoft.AspNetCore.Mvc;
using web2_backend.Models;

namespace web2_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyDataController : ControllerBase
    {
        private static readonly List<MyDataModel> Data = new List<MyDataModel>
        {
            new MyDataModel { Id = 1, Name = "Example 1", Description = "This is the first example" },
            new MyDataModel { Id = 2, Name = "Example 2", Description = "This is the second example" }
        };

        [HttpGet]
        public IEnumerable<MyDataModel> Get()
        {
            return Data;
        }
    }
}
