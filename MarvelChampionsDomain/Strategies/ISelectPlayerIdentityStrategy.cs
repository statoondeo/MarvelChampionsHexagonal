using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectPlayerIdentityStrategy
{
	IHeroIdentity SelectIdentityForPlayer(IHeroPlayer player, List<IHeroIdentity> identities);
}
