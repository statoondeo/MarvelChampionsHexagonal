using MarvelChampionsDomain.Entities;
using MarvelChampionsDomain.Entities.Cards;
using MarvelChampionsDomain.Entities.Commands;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Enums;
using MarvelChampionsDomain.Tools;

namespace MarvelChampionsApplication.SelectPlayerDeck;

public sealed class SelectPlayerDeckUseCase : IUseCase
{
	private readonly SelectPlayerDeckUseCaseInput Input;
	public SelectPlayerDeckUseCase(SelectPlayerDeckUseCaseInput input)
	{
		ArgumentNullException.ThrowIfNull(input);
		Input = input;
	}
	public void Execute()
	{
		List<CollectibleCardDto> deck = new();
		// Ajout des cartes de l'identité
		deck.AddRange(
			ServiceLocator.Instance.Get<ICardSetRepository>()
			.GetById(
				ServiceLocator.Instance.Get<IHeroIdentityRepository>()
				.GetById(Input.Player!.Identity!)
				.CardSetId).Cards);
		// Ajout des cartes du deck
		deck.AddRange(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(Input.Deck!.Id).Cards);
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
			card.SetOwner(Input.Player!.Id);
			cards.Add(card);
		});
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
