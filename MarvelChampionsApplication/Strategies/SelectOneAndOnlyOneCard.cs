using MarvelChampionsApplication.CardSelections;

using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectOneAndOnlyOneCardStrategy : ISelectOneAndOnlyOneCard
{
	private readonly IUseCasePresenter<SelectOneAndOnlyOneCardIO> Presenter;
	public SelectOneAndOnlyOneCardStrategy(IUseCasePresenter<SelectOneAndOnlyOneCardIO> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public CollectibleCardDto Select(List<CollectibleCardDto> identities)
	{
		SelectOneAndOnlyOneCardIO io = new() { Identities = identities };
		Presenter.Present(io);
		return io.SelectedIdentity!;
	}
}
