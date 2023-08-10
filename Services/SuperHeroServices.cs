namespace SuperHeroApi.Services
{
    public class SuperHeroServices : ISuperHeroService
    {
        private readonly List<SuperHeroModel> superHeroes = new()
        {
            new SuperHeroModel {
                Id= 1,
                SuperHeroName="Batman",
                FirstName="Bruce",
                LastName="Wayne",
                Place="Gotham city"                
            },
            new SuperHeroModel {
                Id= 2,
                SuperHeroName="Aquaman",
                FirstName="Arthur",
                LastName="Curry",
                Place="Atlantis"
            }
        };
        public List<SuperHeroModel> AddSuperHero(SuperHeroModel model)
        {
            int newId = superHeroes.Count;
            SuperHeroModel newModel = new SuperHeroModel { 
                Id=newId+1, 
                FirstName=model.FirstName, 
                LastName=model.LastName, 
                Place=model.Place, 
                SuperHeroName=model.SuperHeroName 
            };

            superHeroes.Add(newModel);

            return superHeroes;
        }

        public List<SuperHeroModel> DeleteSuperHero(int id)
        {
            throw new NotImplementedException();
        }

        public List<SuperHeroModel> GetAllSuperHeros()
        {
            return superHeroes;
        }

        public SuperHeroModel? GetSuperHeroDetailsById(int id)
        {
           var result = superHeroes.Find(x=> x.Id == id);
            return result;
        }

        public SuperHeroModel? UpdateSuperHero(SuperHeroModel model, int id)
        {
            throw new NotImplementedException();
        }
    }

    
}

