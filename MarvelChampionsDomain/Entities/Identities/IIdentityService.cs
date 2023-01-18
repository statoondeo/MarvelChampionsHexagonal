using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities;

public interface IHeroIdentityRepository : IRepository<EntityId, IHeroIdentity>, IService { }
public interface IVillainIdentityRepository : IRepository<EntityId, IVillainIdentity>, IService { }