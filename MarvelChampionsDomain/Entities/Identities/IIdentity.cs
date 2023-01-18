using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Identities;

public interface IIdentity : IEntity
{
    EntityId CardSetId { get; }
	string Title { get; }
	int StartingLife { get; }
}
public interface IHeroIdentity : IIdentity
{
	EntityId NemesisCardSetId { get; }
	EntityId Card { get; }
}
public interface IVillainIdentity : IIdentity
{
	EntityId IdentityCardSetId { get; }
	EntityId SchemeCardSetId { get; }
	EntityId StandardCardSetId { get; }
}
