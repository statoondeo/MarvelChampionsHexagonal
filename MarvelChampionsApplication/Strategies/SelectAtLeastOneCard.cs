using MarvelChampionsApplication.CardSelections;

using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Strategies;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectAtLeastOneCardStrategy : ISelectAtLeastOneCardStrategy
{
	private readonly IUseCasePresenter<SelectAtLeastOneCardIO> Presenter;
	public SelectAtLeastOneCardStrategy(IUseCasePresenter<SelectAtLeastOneCardIO> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public List<CollectibleCardDto> Select(List<CollectibleCardDto> identities)
	{
		SelectAtLeastOneCardIO io = new() { Identities = identities };
		Presenter.Present(io);
		return io.SelectedIdentities!;
	}
}
