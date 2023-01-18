using MarvelChampionsDomain.Entities.Identities;

namespace MarvelChampionsApplication.ListHeroIdentities;

public sealed class ListHeroIdentitiesUseCase : IUseCase
{
	private readonly List<IHeroIdentity> Identities;
	private readonly IUseCasePresenter<ListHeroIdentitiesUseCaseOutput> Presenter;
	public ListHeroIdentitiesUseCaseOutput? Output { get; private set; }
	public ListHeroIdentitiesUseCase(List<IHeroIdentity> identities, IUseCasePresenter<ListHeroIdentitiesUseCaseOutput> presenter)
	{
		ArgumentNullException.ThrowIfNull(identities);
		ArgumentNullException.ThrowIfNull(presenter);
		Identities = identities;
		Presenter = presenter;
	}
	public void Execute()
	{
		Output = new ListHeroIdentitiesUseCaseOutput() { Identities = Identities };
		Presenter.Present(Output);
	}
}
