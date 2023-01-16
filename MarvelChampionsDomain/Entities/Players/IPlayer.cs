using MarvelChampionsDomain.Entities.Identities;

namespace MarvelChampionsDomain.Entities.Players;

public interface IPlayer : IEntity
{
	string Nickname { get; }
	IIdentity? Identity { get; }
	int Life { get; }
	void InitIdentity(IIdentity identity);
	void InitLife();
}
