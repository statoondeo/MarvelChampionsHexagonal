using MarvelChampionsDomain.Entities.Services;

namespace MarvelChampionsDomain.Entities.Cards;

public interface ICardService : IService
{
	ICard Register(ICard card);
	void RegisterRange(IList<ICard> cards);
	void Unregister(ICard card);
	IReadOnlyList<ICard> GetCards(Func<ICard, bool> predicate);
}
