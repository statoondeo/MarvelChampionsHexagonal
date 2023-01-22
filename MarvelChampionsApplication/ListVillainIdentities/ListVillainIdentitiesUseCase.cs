using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.ListVillainIdentities;

public sealed class ListVillainIdentitiesUseCase : IUseCase
{
    private readonly List<CollectibleCardDto> Identities;
    private readonly IUseCasePresenter<SelectOneAndOnlyOneCardIO> Presenter;
    public SelectOneAndOnlyOneCardIO? Output { get; private set; }
    public ListVillainIdentitiesUseCase(List<CollectibleCardDto> identities, IUseCasePresenter<SelectOneAndOnlyOneCardIO> presenter)
    {
        ArgumentNullException.ThrowIfNull(identities);
        ArgumentNullException.ThrowIfNull(presenter);
        Identities = identities;
        Presenter = presenter;
    }
    public void Execute()
    {
        Output = new SelectOneAndOnlyOneCardIO() { Identities = this.Identities };
        Presenter.Present(Output);
    }
}
