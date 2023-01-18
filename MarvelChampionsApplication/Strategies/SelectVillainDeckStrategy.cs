using MarvelChampionsApplication.ListAvailableDecks;
using MarvelChampionsApplication.SelectVillainDeck;

using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectVillainDeckStrategy : ISelectVillainDeckStrategy
{
	private readonly IUseCasePresenter<ListDecksUseCaseOutput> Presenter;
	public SelectVillainDeckStrategy(IUseCasePresenter<ListDecksUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public void SelectVillainDeck(List<ICardSet> cardSets)
	{
		// Affichage des decks pour sélection
		ListDecksUseCase listUseCase = new(cardSets, Presenter);
		listUseCase.Execute();

		// On associe le deck sélectionné au joueur
		new SelectVillainDeckUseCase(new()
		{
			Deck = listUseCase.Output!.SelectedDeck
		}).Execute();
	}
}