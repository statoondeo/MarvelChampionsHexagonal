using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Players;

public interface IPlayer : IEntity
{
	EntityId? Identity { get; }
	int Life { get; }
	void InitIdentity(EntityId identity);
	void InitLife();
}
public interface IHeroPlayer : IPlayer
{
	string Nickname { get; }
	public EntityId? DeckCardSetId { get; }
	void SetDeckCardSetId(EntityId deckCardSetId);
}
public interface IVillainPlayer : IPlayer
{
	public EntityId? ModularCardSetId { get; }
	void SetModulatCardSetId(EntityId modularCardSetId);
}
