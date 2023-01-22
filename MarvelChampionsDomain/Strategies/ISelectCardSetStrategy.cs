using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsDomain.Strategies;

public interface ISelectCardSetStrategy
{
	ICardSet SelectCardSet(List<ICardSet> cardSets);
}
