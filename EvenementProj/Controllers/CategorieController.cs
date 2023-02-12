using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoitureApi.Model;
using VoitureAPi2.Services;

namespace VoitureAPi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        ICategorie catServ;
        public CategorieController(ICategorie categser)
        {
            this.catServ = categser;
        }
        [HttpGet("{id}")]
        public async Task< Categorie> getCategorie(int id)
        {
            return await catServ.getCategorie(id);
        }

        [HttpPost]
        public Task<Categorie> getCategorie([FromBody]Categorie categorie)
        {
            return   catServ.addUpdateCategorie(categorie);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deletecat(int id)
        {
            Categorie categorie = await getCategorie(id);
            catServ.removeCategorie(categorie);
            return Ok();
        }

        [HttpGet()]
        public Task< IEnumerable<Categorie>> getAllCategories()
        {
           return catServ.getAllCategories();
        }
    }
}
