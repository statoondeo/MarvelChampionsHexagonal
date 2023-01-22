using MarvelChampionsApplication.ListVillainIdentities;

using MarvelChampionsDomain.Entities.Sets;
using MarvelChampionsDomain.Strategies;
using MarvelChampionsDomain.ValueObjects;

namespace MarvelChampionsApplication.Strategies;

public sealed class SelectOneAndOnlyOneCard : ISelectOneAndOnlyOneCard
{
	private readonly IUseCasePresenter<SelectOneAndOnlyOneCardIO> Presenter;
	public SelectOneAndOnlyOneCard(IUseCasePresenter<SelectOneAndOnlyOneCardIO> presenter)
	{
		ArgumentNullException.ThrowIfNull(presenter);
		Presenter = presenter;
	}
	public EntityId Select(List<CollectibleCardDto> identities)
	{
		ListVillainIdentitiesUseCase listdentitiesUseCase = new(identities, Presenter);
		listdentitiesUseCase.Execute();
		return listdentitiesUseCase.Output!.SelectedIdentity!;
	}
}
