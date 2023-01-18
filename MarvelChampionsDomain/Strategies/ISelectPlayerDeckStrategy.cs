using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectPlayerDeckStrategy
{
	void SelectDeckForPlayer(IHeroPlayer player, List<ICardSet> cardSets);
}
