using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace SuperHeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;


        public SuperHeroController(ISuperHeroService superHeroService) {
            _superHeroService = superHeroService;
        }
        [HttpGet]
        public ActionResult<List<SuperHeroModel>> GetAllSuperHeroes() {
            var result = _superHeroService.GetAllSuperHeros();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<SuperHeroModel> GetSuperHeroById(int id)
        {
            var result = _superHeroService.GetSuperHeroDetailsById(id);
            if (result == null) return NotFound("No SuperHero found as per given Id");
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<List<SuperHeroModel>> AddNewHero(SuperHeroModel model) { 
            var result = _superHeroService.AddSuperHero(model);
            return Ok(result);
        }
    }
}
