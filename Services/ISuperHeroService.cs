namespace SuperHeroApi.Services
{
    public interface ISuperHeroService
    {
        List<SuperHeroModel> GetAllSuperHeros();
        SuperHeroModel? GetSuperHeroDetailsById(int id);
        List<SuperHeroModel> AddSuperHero(SuperHeroModel model);
        SuperHeroModel? UpdateSuperHero(SuperHeroModel model, int id);
        List<SuperHeroModel> DeleteSuperHero(int id);
    }
}
