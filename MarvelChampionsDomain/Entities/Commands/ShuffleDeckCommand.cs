using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class ShuffleDeckCommand : ICommand
{
	private readonly EntityId Owner;
	public ShuffleDeckCommand(EntityId owner)
	{
		ArgumentNullException.ThrowIfNull(owner);
		Owner = owner;
	}
	public void Execute() 
	{
		List<ICard> deckContent = ServiceLocator.Instance.Get<ICardService>()
									.GetCards(card => Owner.Equals(card.Owner) && LocationEnum.Deck.Equals(card.Location));
		for (int i = 0; i < deckContent.Count - 1; i++)
		{
			int newOrder = Random.Shared.Next(i + 1, deckContent.Count);
			int tmpOrder = deckContent[i].Order;
			deckContent[i].SetOrder(deckContent[newOrder].Order);
			deckContent[newOrder].SetOrder(tmpOrder);
		}
	}
}
