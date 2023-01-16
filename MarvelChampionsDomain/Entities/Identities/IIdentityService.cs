using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities;

public interface IIdentityRepository : IRepository<EntityId, IIdentity>, IService { }