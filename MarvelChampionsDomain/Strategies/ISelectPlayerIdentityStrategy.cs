using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectPlayerIdentityStrategy
{
	void SelectIdentityForPlayer(IHeroPlayer player, List<IHeroIdentity> identities);
}
