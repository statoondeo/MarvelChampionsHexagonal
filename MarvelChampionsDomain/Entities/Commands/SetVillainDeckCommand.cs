using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetVillainDeckCommand : ICommand
{	public void Execute()
	{
		ICardSet selectedCardSet = ServiceLocator.Instance.Get<IGameService>()
		.SelectCardSetStrategy
		.SelectCardSet(
			ServiceLocator.Instance.Get<ICardSetRepository>()
				.GetAll()
				.Where(cardSet => !cardSet.Identity && cardSet.Encounter && !cardSet.Standard)
				.ToList());

		List<CollectibleCardDto> deck = new();
		IVillainPlayer villain = ServiceLocator.Instance.Get<IVillainService>().Villain!;

		// Ajout des cartes du deck
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(selectedCardSet.Id).Cards);

		List<ICard> cards = new();
		deck.ForEach(collectibleCard =>
		{
			CardBuilder cardBuilder = new(
				collectibleCard.Id!,
				collectibleCard.CardSet!,
				collectibleCard.Title!,
				collectibleCard.Type!,
				collectibleCard.Classification!);
			if (collectibleCard.SetupCommand is not null) cardBuilder.WithSetupCommand(collectibleCard.SetupCommand);
			cardBuilder.WithLocation(LocationEnum.Deck);
			cardBuilder.WithOwner(villain.Id);
			cards.Add(cardBuilder.Build());
		});
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
