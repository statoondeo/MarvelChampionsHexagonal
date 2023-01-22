using MarvelChampionsApplication.ListHeroIdentities;

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
	public IHeroIdentity SelectIdentityForPlayer(IHeroPlayer player, List<IHeroIdentity> identities)
	{
		// Affichage des identités pour sélection
		ListHeroIdentitiesUseCase listIdentitiesUseCase = new(identities, Presenter);
		listIdentitiesUseCase.Execute();

		return listIdentitiesUseCase.Output!.SelectedIdentity!;
	}
}
