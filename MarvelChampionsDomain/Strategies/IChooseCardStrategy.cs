using MarvelChampionsDomain.Entities.Cards;

namespace MarvelChampionsDomain.Entities;

public interface IChooseCardStrategy
{
	IList<ICard> ChooseCards(Func<ICard, bool> amongFilter);
}
