using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.ListCardSets;

public sealed class ListCardSetsUseCase : IUseCase
{
	private readonly List<ICardSet> CardSets;
	private readonly IUseCasePresenter<ListCardSetsUseCaseOutput> Presenter;
	public ListCardSetsUseCaseOutput? Output { get; private set; }
	public ListCardSetsUseCase(List<ICardSet> cardSets, IUseCasePresenter<ListCardSetsUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(cardSets);
		ArgumentNullException.ThrowIfNull(presenter);
		CardSets = cardSets;
		Presenter = presenter;
	}
	public void Execute()
	{
		Output = new ListCardSetsUseCaseOutput() { CardSets = CardSets };
		Presenter.Present(Output);
	}
}
