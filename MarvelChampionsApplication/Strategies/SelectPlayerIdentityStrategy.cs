using MarvelChampionsApplication.ListHeroIdentities;
using MarvelChampionsApplication.SelectPlayerIdentity;

using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Entities.Players;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectPlayerIdentityStrategy : ISelectPlayerIdentityStrategy
{
	private readonly IUseCasePresenter<ListHeroIdentitiesUseCaseOutput> Presenter;
	public SelectPlayerIdentityStrategy(IUseCasePresenter<ListHeroIdentitiesUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public void SelectIdentityForPlayer(IHeroPlayer player, List<IHeroIdentity> identities)
	{
		// Affichage des identités pour sélection
		ListHeroIdentitiesUseCase listAvailableIdentitiesUseCase = new(identities, Presenter);
		listAvailableIdentitiesUseCase.Execute();

		// On associe l'identité sélectionnée au joueur
		new SelectPlayerIdentityUseCase(new()
		{
			Player = player,
			Identity = listAvailableIdentitiesUseCase.Output!.SelectedIdentity
		}).Execute();
	}
}
