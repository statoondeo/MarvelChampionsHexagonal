using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Players;

namespace MarvelChampionsDomain.Strategies
{
	public interface ISelectPlayerIdentityStrategy
	{
		void SelectIdentityForPlayer(IPlayer player);
	}
}
