using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class RenumCardsCommand : ICommand
{
	private readonly EntityId Owner;
	public RenumCardsCommand(EntityId owner) => Owner = owner;

	public void Execute()
	{
		ICardService cardService = ServiceLocator.Instance.Get<ICardService>();
		foreach (LocationEnum location in new List<LocationEnum> {	LocationEnum.Exil,
																	LocationEnum.Battlefield,
																	LocationEnum.Hand,
																	LocationEnum.Discard,
																	LocationEnum.Deck,
																	LocationEnum.MainScheme}) 
		{
			int i = 0;
			cardService
				.GetCards(card => Owner.Equals(card.Owner) && location.Equals(card.Location))
				.ForEach(card => card.SetOrder(i++));
		}
	}
}
