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
}
public interface IVillainPlayer : IPlayer
{
}
