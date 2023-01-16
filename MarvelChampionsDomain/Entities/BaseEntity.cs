using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Basics;

public abstract class BaseEntity : IEntity
{
    public EntityId Id { get; }
    protected BaseEntity(EntityId id) => Id = id;
    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType() || obj is not BaseEntity entity) return false;
        return Id == entity.Id;
    }
    public override int GetHashCode() => Id.GetHashCode();
}
