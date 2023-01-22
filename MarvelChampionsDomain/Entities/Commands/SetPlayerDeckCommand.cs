using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Services;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsDomain.Entities.Commands;

public sealed class SetPlayerDeckCommand : ICommand
{
	private readonly IHeroPlayer Player;
	public SetPlayerDeckCommand(IHeroPlayer player) => Player = player;
	public void Execute()
	{
		// Sélection du deck du joueur
		ICardSet selectedDeck = ServiceLocator.Instance.Get<IGameService>()
			.SelectCardSetStrategy
			.SelectCardSet(
				ServiceLocator.Instance.Get<ICardSetRepository>()
					.GetAll()
					.Where(cardSet => !cardSet.Identity && !cardSet.Encounter && !cardSet.Standard)
					.ToList());

		// Conversion en cartes jouables
		List<ICard> cards = new();
		ServiceLocator.Instance.Get<ICardSetRepository>()
			.GetById(selectedDeck.Id)
			.Cards
			.ForEach(collectibleCard =>
			{
				CardBuilder cardBuilder = new(
					collectibleCard.Id!,
					collectibleCard.CardSet!,
					collectibleCard.Title!,
					collectibleCard.Type!,
					collectibleCard.Classification!);
				cardBuilder.WithLocation(LocationEnum.Deck);
				cardBuilder.WithOwner(Player.Id);
				cards.Add(cardBuilder.Build());
			});

		// Ajout des cartes au service
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
