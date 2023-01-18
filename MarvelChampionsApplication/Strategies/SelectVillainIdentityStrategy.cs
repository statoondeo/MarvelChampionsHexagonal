using MarvelChampionsApplication.ListVillainIdentities;
using MarvelChampionsApplication.SelectVillainIdenity;

using MarvelChampionsDomain.Entities.Identities;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectVillainIdentityStrategy : ISelectVillainIdentityStrategy
{
	private readonly IUseCasePresenter<ListVillainIdentitiesUseCaseOutput> Presenter;
	public SelectVillainIdentityStrategy(IUseCasePresenter<ListVillainIdentitiesUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public void SelectIdentity(List<IVillainIdentity> identities)
	{
		// Affichage des identités pour sélection
		ListVillainIdentitiesUseCase listdentitiesUseCase = new(identities, Presenter);
		listdentitiesUseCase.Execute();

		// On associe l'identité sélectionnée au joueur
		new SelectVillainIdentityUseCase(new()
		{
			Identity = listdentitiesUseCase.Output!.SelectedIdentity
		}).Execute();
	}
}
