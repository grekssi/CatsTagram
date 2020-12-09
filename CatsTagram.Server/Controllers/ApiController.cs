using Microsoft.AspNetCore.Mvc;

namespace CatsTagram.Server.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
