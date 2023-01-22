using MarvelChampionsApplication.ListCardSets;
using MarvelChampionsApplication.ListHeroIdentities;
using MarvelChampionsApplication.ListVillainIdentities;
using MarvelChampionsApplication.RegisterPlayer;

using MarvelChampionsDomain.Entities;

namespace MarvelChampionsApplication.CreateAndStartNewGame;

public sealed class CreateAndStartNewGameUseCaseInput
{
	public IUseCasePresenter<RegisterPlayerUseCaseInput>? RegisterPlayerPresenter { get; set; }
	public IUseCasePresenter<ListHeroIdentitiesUseCaseOutput>? SelectPlayerIdentityPresenter { get; set; }
	public IUseCasePresenter<SelectOneAndOnlyOneCardIO>? SelectVillainIdentityPresenter { get; set; }
	public IUseCasePresenter<ListCardSetsUseCaseOutput>? SelectDeckPresenter { get; set; }
    public IChooseCardStrategy? SelectCardStrategy { get; set; }
}
