using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities;

public interface IEntity
{
    EntityId Id { get; }
}
