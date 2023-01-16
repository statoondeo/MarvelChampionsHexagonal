using MarvelChampionsApplication.ListAvailableIdentities;
using MarvelChampionsApplication.SelectPlayerIdentity;

using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectPlayerIdentityStrategy : ISelectPlayerIdentityStrategy
{
	private readonly IUseCasePresenter<ListAvailableIdentitiesUseCaseOutput> Presenter;
	public SelectPlayerIdentityStrategy(IUseCasePresenter<ListAvailableIdentitiesUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public void SelectIdentityForPlayer(IPlayer player)
	{
		// Affichage des identités pour sélection
		ListAvailableIdentitiesUseCase listAvailableIdentitiesUseCase = new(Presenter);
		listAvailableIdentitiesUseCase.Execute();

		// On associe l'identité sélectionnée au joueur
		new SelectPlayerIdentityUseCase(new()
		{
			Player = player,
			Identity = listAvailableIdentitiesUseCase.Output!.SelectedIdentity
		}).Execute();
	}
}
