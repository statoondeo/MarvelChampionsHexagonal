using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.ListAvailableDecks;

public sealed class ListDecksUseCase : IUseCase
{
	private readonly List<ICardSet> CardSets;
	private readonly IUseCasePresenter<ListDecksUseCaseOutput> Presenter;
	public ListDecksUseCaseOutput? Output { get; private set; }
    public ListDecksUseCase(List<ICardSet> cardSets, IUseCasePresenter<ListDecksUseCaseOutput> presenter)
    {
		ArgumentNullException.ThrowIfNull(cardSets);
		ArgumentNullException.ThrowIfNull(presenter);
		CardSets = cardSets;
		Presenter = presenter;
    }
    public void Execute()
    {
		Output = new ListDecksUseCaseOutput () { Decks = CardSets };
        Presenter.Present(Output);
    }
}
