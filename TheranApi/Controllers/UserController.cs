using Microsoft.AspNetCore.Mvc;

namespace TheranApi.Controllers
{
    [ApiController]
    [Route("api/v2/[controller]")]
    public class UserController : ControllerBase
    {
        public List<string> Users = new() { "Samuel", "Noemi", "Franz" };

        // https://localhost:7055/api/v2/User/2
        [HttpGet("{id}")]
        public string GetUsersWithIdRequired(int id)
        {
            if(Users.Count >= id)
                return Users.ElementAt(id - 1);
            return "No hay el usuario";
        }

        // https://localhost:7055/api/v2/User?name=Franz
        [HttpGet]
        public string ExistUsersByName(string name)
        {
           var result =  Users.Find(names => names == name);

            if (result == null)
                return "No hay el nombre";

            return "El nombre si existe";
        }

    }
}
