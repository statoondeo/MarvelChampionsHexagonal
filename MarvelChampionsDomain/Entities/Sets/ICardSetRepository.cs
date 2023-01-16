using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Sets;

public interface ICardSetRepository : IRepository<EntityId, ICardSet>, IService { }
