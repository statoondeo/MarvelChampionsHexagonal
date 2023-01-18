using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Cards;

public interface ICardService : IService
{
	ICard Register(ICard card);
	void RegisterRange(IList<ICard> cards);
	void Unregister(ICard card);
	ICard GetCard(EntityId id);
	IReadOnlyList<ICard> GetCards(Func<ICard, bool> predicate);
}
