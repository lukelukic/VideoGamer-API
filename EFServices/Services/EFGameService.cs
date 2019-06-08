using System.Linq;
using Aplication.Interfaces;
using Aplication.Pagination;
using Aplication.Searches;
using EntityConfiguration;
using SharedModels.DTO;
using SharedModels.Fluent.Game;

namespace EFServices.Services
{
    public class EFGameService: BaseService<Game, GameSearchRequest>, IGameService
    {
        public EFGameService(VideoGamerDbContext context) : base(context)
        {
        }

        public PagedResponse<Game> All(GameSearchRequest request)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public void Create(GameFluentValidator dto)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new System.NotImplementedException();
        }

        public Game Find(object id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(GameFluentValidator dto)
        {
            throw new System.NotImplementedException();
        }

        protected override IQueryable<Game> BuildingQuery(IQueryable<Game> query, GameSearchRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}