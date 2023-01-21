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
		ServiceLocator.Instance.Get<IGameService>()
			.SelectPlayerDeckStrategy
			.SelectDeckForPlayer(
				Player,
				ServiceLocator.Instance.Get<ICardSetRepository>()
					.GetAll()
					.Where(cardSet => !cardSet.Identity && !cardSet.Encounter && !cardSet.Standard)
					.ToList());

		List<CollectibleCardDto> deck = new();
		
		// Ajout des cartes du deck
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(Player.DeckCardSetId!).Cards);

		// Conversion en cartes jouables
		List<ICard> cards = new();
		deck.ForEach(collectibleCard =>
		{
			CardBuilder cardBuilder = new CardBuilder(
				collectibleCard.Id!,
				collectibleCard.CardSet!,
				collectibleCard.Title!,
				collectibleCard.Type!,
				ClassificationEnum.None);
			ICard card = cardBuilder.Build();
			card.SetOwner(Player.Id);
			cards.Add(card);
		});

		// Ajout des cartes au service
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
