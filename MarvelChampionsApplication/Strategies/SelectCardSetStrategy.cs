using MarvelChampionsApplication.ListCardSets;

using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectCardSetStrategy : ISelectCardSetStrategy
{
	private readonly IUseCasePresenter<ListCardSetsUseCaseOutput> Presenter;
	public SelectCardSetStrategy(IUseCasePresenter<ListCardSetsUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public ICardSet SelectCardSet(List<ICardSet> cardSets)
	{
		// Affichage des decks pour sélection
		ListCardSetsUseCase listUseCase = new(cardSets, Presenter);
		listUseCase.Execute();

		// On associe le deck sélectionné au joueur
		return listUseCase.Output!.SelectedCardSet!;
	}
}
