using MarvelChampionsDomain.Entities.Sets;

namespace MarvelChampionsApplication.CardSelections;

public sealed class SelectOneAndOnlyOneCardUseCase : IUseCase
{
	private readonly List<CollectibleCardDto> Identities;
	private readonly IUseCasePresenter<SelectOneAndOnlyOneCardIO> Presenter;
	public SelectOneAndOnlyOneCardIO? Output { get; private set; }
	public SelectOneAndOnlyOneCardUseCase(List<CollectibleCardDto> identities, IUseCasePresenter<SelectOneAndOnlyOneCardIO> presenter)
	{
		ArgumentNullException.ThrowIfNull(identities);
		ArgumentNullException.ThrowIfNull(presenter);
		Identities = identities;
		Presenter = presenter;
	}
	public void Execute()
	{
		Output = new SelectOneAndOnlyOneCardIO() { Identities = Identities };
		Presenter.Present(Output);
	}
}
