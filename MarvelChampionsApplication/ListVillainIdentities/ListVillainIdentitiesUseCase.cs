using MarvelChampionsDomain.Entities.Identities;

namespace MarvelChampionsApplication.ListVillainIdentities;

public sealed class ListVillainIdentitiesUseCase : IUseCase
{
    private readonly List<IVillainIdentity> Identities;
    private readonly IUseCasePresenter<ListVillainIdentitiesUseCaseOutput> Presenter;
    public ListVillainIdentitiesUseCaseOutput? Output { get; private set; }
    public ListVillainIdentitiesUseCase(List<IVillainIdentity> identities, IUseCasePresenter<ListVillainIdentitiesUseCaseOutput> presenter)
    {
        ArgumentNullException.ThrowIfNull(identities);
        ArgumentNullException.ThrowIfNull(presenter);
        Identities = identities;
        Presenter = presenter;
    }
    public void Execute()
    {
        Output = new ListVillainIdentitiesUseCaseOutput() { Identities = Identities };
        Presenter.Present(Output);
    }
}
