using MarvelChampionsApplication.ListAvailableDecks;
using MarvelChampionsApplication.ListHeroIdentities;
using MarvelChampionsApplication.ListVillainIdentities;
using MarvelChampionsApplication.RegisterPlayer;

using MarvelChampionsDomain.Entities;

namespace MarvelChampionsApplication.CreateAndStartNewGame;

public sealed class CreateAndStartNewGameUseCaseInput
{
	public IUseCasePresenter<RegisterPlayerUseCaseInput>? RegisterPlayerPresenter { get; set; }
	public IUseCasePresenter<ListHeroIdentitiesUseCaseOutput>? SelectPlayerIdentityPresenter { get; set; }
	public IUseCasePresenter<ListVillainIdentitiesUseCaseOutput>? SelectVillainIdentityPresenter { get; set; }
	public IUseCasePresenter<ListDecksUseCaseOutput>? SelectDeckPresenter { get; set; }
    public IChooseCardStrategy? SelectCardStrategy { get; set; }
}
