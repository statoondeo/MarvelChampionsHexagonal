using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectVillainDeckStrategy
{
	void SelectVillainDeck(List<ICardSet> cardSets);
}