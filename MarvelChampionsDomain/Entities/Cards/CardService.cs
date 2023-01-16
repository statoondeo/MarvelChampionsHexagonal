using System.Linq;

using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Cards;

public sealed class CardService : ICardService
{
	private readonly List<ICard> CardsAtlas;
	public CardService() => CardsAtlas = new List<ICard>();
	public ICard Register(ICard card)
	{
		CardsAtlas.Add(card ?? throw new ArgumentNullException(nameof(card)));
		Logger.Log($"CardService.Register -> {card}");
		return card;
	}
	public void RegisterRange(IList<ICard> cards)
	{
		if ((cards is null) || !cards.Any()) throw new ArgumentNullException(nameof(cards));
		CardsAtlas.AddRange(cards);
	}
	public void Unregister(ICard card)
	{
		CardsAtlas.Remove(card ?? throw new ArgumentNullException(nameof(card)));
		Logger.Log($"CardService.Unregister -> {card}");
	}
	public IReadOnlyList<ICard> GetCards(Func<ICard, bool> predicate)
	{
		return CardsAtlas.Where(predicate).ToList().AsReadOnly();
	}

}