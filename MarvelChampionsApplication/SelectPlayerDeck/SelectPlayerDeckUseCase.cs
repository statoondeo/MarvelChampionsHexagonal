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
        ICardSet deck = new CardSet(false, string.Empty);
		deck.Append(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(Input.Player!.Identity!.CardSetId));
		deck.Append(ServiceLocator.Instance.Get<ICardSetRepository>().GetById(Input.Deck!.Id));
        List<ICard> cards = new List<ICard>();
        deck.Cards.ForEach(collectibleCard =>
        {
            ICard card = new Card(
                collectibleCard.Title!,
                string.Empty, 
                TypeEnum.None,
				LocationEnum.None,
				ClassificationEnum.None,
                new NullCommand(),
				new NullCommand());
			card.SetOwner(Input.Player!);
			cards.Add(card);
		});
		Input.Player!.Identity!.SetCard(cards[0]);
		ServiceLocator.Instance.Get<ICardService>().RegisterRange(cards);
	}
}
