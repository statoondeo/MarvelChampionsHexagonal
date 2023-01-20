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
		ServiceLocator.Instance.Get<IGameService>()
			.SelectPlayerDeckStrategy
			.SelectDeckForPlayer(
				Player,
				ServiceLocator.Instance.Get<ICardSetRepository>()
					.GetAll()
					.Where(cardSet => !cardSet.Identity && !cardSet.Encounter && !cardSet.Standard)
					.ToList());

		List<CollectibleCardDto> deck = new();
		// Ajout des cartes de l'identité
		deck.AddRange(
			ServiceLocator.Instance.Get<ICardSetRepository>()
			.GetById(
				ServiceLocator.Instance.Get<IHeroIdentityRepository>()
				.GetById(Player.Identity!)
				.CardSetId).Cards);
		// Ajout des cartes du deck
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(Player.DeckCardSetId!).Cards);
		List<ICard> cards = new();
		deck.ForEach(collectibleCard =>
		{
			ICard card = new Card(
				collectibleCard.Id!,
				collectibleCard.CardSet!,
				collectibleCard.Title!,
				string.Empty,
				TypeEnum.None,
				LocationEnum.None,
				ClassificationEnum.None,
				new NullCommand(),
				new NullCommand());
			card.SetOwner(Player.Id);
			cards.Add(card);
		});
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
