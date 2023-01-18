using MarvelChampionsApplication.ListAvailableDecks;
using MarvelChampionsApplication.SelectPlayerDeck;

using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectPlayerDeckStrategy : ISelectPlayerDeckStrategy
{
	private readonly IUseCasePresenter<ListDecksUseCaseOutput> Presenter;
	public SelectPlayerDeckStrategy(IUseCasePresenter<ListDecksUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public void SelectDeckForPlayer(IHeroPlayer player, List<ICardSet> cardSets)
	{
		// Affichage des decks pour sélection
		ListDecksUseCase listUseCase = new(cardSets, Presenter);
		listUseCase.Execute();

		// On associe le deck sélectionné au joueur
		new SelectPlayerDeckUseCase(new()
		{
			Player = player,
			Deck = listUseCase.Output!.SelectedDeck
		}).Execute();
	}
}
